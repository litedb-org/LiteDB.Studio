﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Drawing;
using LiteDB.Studio.ICSharpCode.TextEditor.Document;
using LiteDB.Studio.ICSharpCode.TextEditor.Document.FoldingStrategy;
using LiteDB.Studio.ICSharpCode.TextEditor.Gui;

namespace LiteDB.Studio.ICSharpCode.TextEditor.Actions
{
    public class CaretLeft : AbstractEditAction
    {
        public override void Execute(TextArea textArea)
        {
            var position = textArea.Caret.Position;
            var foldings = textArea.Document.FoldingManager.GetFoldedFoldingsWithEnd(position.Y);
            FoldMarker justBeforeCaret = null;
            foreach (var fm in foldings)
                if (fm.EndColumn == position.X)
                {
                    justBeforeCaret = fm;
                    break; // the first folding found is the folding with the smallest Startposition
                }

            if (justBeforeCaret != null)
            {
                position.Y = justBeforeCaret.StartLine;
                position.X = justBeforeCaret.StartColumn;
            }
            else
            {
                if (position.X > 0)
                {
                    --position.X;
                }
                else if (position.Y > 0)
                {
                    var lineAbove = textArea.Document.GetLineSegment(position.Y - 1);
                    position = new TextLocation(lineAbove.Length, position.Y - 1);
                }
            }

            textArea.Caret.Position = position;
            textArea.SetDesiredColumn();
        }
    }

    public class CaretRight : AbstractEditAction
    {
        public override void Execute(TextArea textArea)
        {
            var curLine = textArea.Document.GetLineSegment(textArea.Caret.Line);
            var position = textArea.Caret.Position;
            var foldings = textArea.Document.FoldingManager.GetFoldedFoldingsWithStart(position.Y);
            FoldMarker justBehindCaret = null;
            foreach (var fm in foldings)
                if (fm.StartColumn == position.X)
                {
                    justBehindCaret = fm;
                    break;
                }

            if (justBehindCaret != null)
            {
                position.Y = justBehindCaret.EndLine;
                position.X = justBehindCaret.EndColumn;
            }
            else
            {
                // no folding is interesting
                if (position.X < curLine.Length || textArea.TextEditorProperties.AllowCaretBeyondEOL)
                {
                    ++position.X;
                }
                else if (position.Y + 1 < textArea.Document.TotalNumberOfLines)
                {
                    ++position.Y;
                    position.X = 0;
                }
            }

            textArea.Caret.Position = position;
            textArea.SetDesiredColumn();
        }
    }

    public class CaretUp : AbstractEditAction
    {
        public override void Execute(TextArea textArea)
        {
            var position = textArea.Caret.Position;
            var lineNr = position.Y;
            var visualLine = textArea.Document.GetVisibleLine(lineNr);
            if (visualLine > 0)
            {
                var pos = new Point(textArea.TextView.GetDrawingXPos(lineNr, position.X),
                    textArea.TextView.DrawingPosition.Y + (visualLine - 1) * textArea.TextView.FontHeight -
                    textArea.TextView.TextArea.VirtualTop.Y);
                textArea.Caret.Position = textArea.TextView.GetLogicalPosition(pos);
                textArea.SetCaretToDesiredColumn();
            }

//			if (textArea.Caret.Line  > 0) {
//				textArea.SetCaretToDesiredColumn(textArea.Caret.Line - 1);
//			}
        }
    }

    public class CaretDown : AbstractEditAction
    {
        public override void Execute(TextArea textArea)
        {
            var position = textArea.Caret.Position;
            var lineNr = position.Y;
            var visualLine = textArea.Document.GetVisibleLine(lineNr);
            if (visualLine < textArea.Document.GetVisibleLine(textArea.Document.TotalNumberOfLines))
            {
                var pos = new Point(textArea.TextView.GetDrawingXPos(lineNr, position.X),
                    textArea.TextView.DrawingPosition.Y
                    + (visualLine + 1) * textArea.TextView.FontHeight
                    - textArea.TextView.TextArea.VirtualTop.Y);
                textArea.Caret.Position = textArea.TextView.GetLogicalPosition(pos);
                textArea.SetCaretToDesiredColumn();
            }

//			if (textArea.Caret.Line + 1 < textArea.Document.TotalNumberOfLines) {
//				textArea.SetCaretToDesiredColumn(textArea.Caret.Line + 1);
//			}
        }
    }

    public class WordRight : CaretRight
    {
        public override void Execute(TextArea textArea)
        {
            var line = textArea.Document.GetLineSegment(textArea.Caret.Position.Y);
            var oldPos = textArea.Caret.Position;
            TextLocation newPos;
            if (textArea.Caret.Column >= line.Length)
            {
                newPos = new TextLocation(0, textArea.Caret.Line + 1);
            }
            else
            {
                var nextWordStart = TextUtilities.FindNextWordStart(textArea.Document, textArea.Caret.Offset);
                newPos = textArea.Document.OffsetToPosition(nextWordStart);
            }

            // handle fold markers
            var foldings = textArea.Document.FoldingManager.GetFoldingsFromPosition(newPos.Y, newPos.X);
            foreach (var marker in foldings)
                if (marker.IsFolded)
                {
                    if (oldPos.X == marker.StartColumn && oldPos.Y == marker.StartLine)
                        newPos = new TextLocation(marker.EndColumn, marker.EndLine);
                    else
                        newPos = new TextLocation(marker.StartColumn, marker.StartLine);
                    break;
                }

            textArea.Caret.Position = newPos;
            textArea.SetDesiredColumn();
        }
    }

    public class WordLeft : CaretLeft
    {
        public override void Execute(TextArea textArea)
        {
            var oldPos = textArea.Caret.Position;
            if (textArea.Caret.Column == 0)
            {
                base.Execute(textArea);
            }
            else
            {
                var line = textArea.Document.GetLineSegment(textArea.Caret.Position.Y);

                var prevWordStart = TextUtilities.FindPrevWordStart(textArea.Document, textArea.Caret.Offset);

                var newPos = textArea.Document.OffsetToPosition(prevWordStart);

                // handle fold markers
                var foldings = textArea.Document.FoldingManager.GetFoldingsFromPosition(newPos.Y, newPos.X);
                foreach (var marker in foldings)
                    if (marker.IsFolded)
                    {
                        if (oldPos.X == marker.EndColumn && oldPos.Y == marker.EndLine)
                            newPos = new TextLocation(marker.StartColumn, marker.StartLine);
                        else
                            newPos = new TextLocation(marker.EndColumn, marker.EndLine);
                        break;
                    }

                textArea.Caret.Position = newPos;
                textArea.SetDesiredColumn();
            }
        }
    }

    public class ScrollLineUp : AbstractEditAction
    {
        public override void Execute(TextArea textArea)
        {
            textArea.AutoClearSelection = false;

            textArea.MotherTextAreaControl.VScrollBar.Value = Math.Max(
                textArea.MotherTextAreaControl.VScrollBar.Minimum,
                textArea.VirtualTop.Y - textArea.TextView.FontHeight);
        }
    }

    public class ScrollLineDown : AbstractEditAction
    {
        public override void Execute(TextArea textArea)
        {
            textArea.AutoClearSelection = false;
            textArea.MotherTextAreaControl.VScrollBar.Value = Math.Min(
                textArea.MotherTextAreaControl.VScrollBar.Maximum,
                textArea.VirtualTop.Y + textArea.TextView.FontHeight);
        }
    }
}