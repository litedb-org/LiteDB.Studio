// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="none" email=""/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Drawing;

namespace LiteDB.Studio.ICSharpCode.TextEditor.Util
{
    internal class TipSpacer : TipSection
    {
        private SizeF spacerSize;

        public TipSpacer(Graphics graphics, SizeF size) : base(graphics)
        {
            spacerSize = size;
        }

        public override void Draw(PointF location)
        {
        }

        protected override void OnMaximumSizeChanged()
        {
            base.OnMaximumSizeChanged();

            SetRequiredSize(new SizeF
            (Math.Min(MaximumSize.Width, spacerSize.Width),
                Math.Min(MaximumSize.Height, spacerSize.Height)));
        }
    }
}