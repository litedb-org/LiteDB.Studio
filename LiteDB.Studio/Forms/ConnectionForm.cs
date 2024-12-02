using ICSharpCode.TextEditor.Util;

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LiteDB.Studio.Forms
{
    public partial class ConnectionForm : Form
    {
        private const long MB = 1024 * 1024;

        public ConnectionString ConnectionString = new ConnectionString();

        public ConnectionForm(ConnectionString cs)
        {
            InitializeComponent();

            txtFilename.Text = cs.Filename;
            chkReadonly.Checked = cs.ReadOnly;
            txtInitialSize.Text = (cs.InitialSize / MB).ToString();

            chkUpgrade.Checked = cs.Upgrade;

            cmbCulture.DataSource =
                CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Select(x => x.LCID)
                .Distinct()
                .Where(x => x != 4096)
                .Select(x => CultureInfo.GetCultureInfo(x).Name)
                .ToList();

            var sort = new List<string>();
            sort.Add("");
            sort.AddRange(Enum.GetNames(typeof(CompareOptions)).Cast<string>());

            cmbSort.DataSource = sort;

            if (cs.Collation != null)
            {
                cmbCulture.SelectedIndex = cmbCulture.FindString(cs.Collation.Culture.Name);
                cmbSort.SelectedIndex = cmbSort.FindString(cs.Collation.SortOptions.ToString());
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            this.ConnectionString.Connection =
                radModeDirect.Checked ? ConnectionType.Direct :
                radModeShared.Checked ? ConnectionType.Shared : ConnectionType.Direct;

            this.ConnectionString.Filename = txtFilename.Text;
            this.ConnectionString.ReadOnly = chkReadonly.Checked;
            this.ConnectionString.Upgrade = chkUpgrade.Checked;
            this.ConnectionString.Password = txtPassword.Text.Trim().Length > 0 ? txtPassword.Text.Trim() : null;

            if (int.TryParse(txtInitialSize.Text, out var initialSize))
            {
                this.ConnectionString.InitialSize = initialSize * MB;
            }

            if (cmbCulture.SelectedIndex > 0)
            {
                var collation = cmbCulture.SelectedItem.ToString();

                if (cmbSort.SelectedIndex > 0)
                {
                    collation += "/" + cmbSort.SelectedItem.ToString();
                }

                this.ConnectionString.Collation = new Collation(collation);
            }

            this.DialogResult = DialogResult.OK;
            // make it last db
            AppSettingsManager.ApplicationSettings.LastConnectionStrings = this.ConnectionString;
            // add to recent list
            AppSettingsManager.AddToRecentList(this.ConnectionString);
            this.Close();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = txtFilename.Text;

            openFileDialog.CheckFileExists = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = openFileDialog.FileName;
            }
        }

        private void chkReadonly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReadonly.Checked)
            {
                chkUpgrade.Checked = false;
                chkUpgrade.Enabled = false;
            }
            else
            {
                chkUpgrade.Enabled = true;
            }
        }

        private void ConnectionForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ConnectionForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                txtFilename.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            }
        }

        private void buttonBuildDefaultFileName_Click(object sender, EventArgs e)
        {
            var fileName = $"{DateTime.Now:yyyyMMddHHmmss}.db";
            var fullFileNamePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            txtFilename.Text = fullFileNamePath;
        }
    }
}
