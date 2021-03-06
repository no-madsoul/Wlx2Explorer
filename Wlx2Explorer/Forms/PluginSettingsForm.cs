﻿using System;
using System.IO;
using System.Windows.Forms;
using Wlx2Explorer.Utils;

namespace Wlx2Explorer.Forms
{
    partial class PluginSettingsForm : Form
    {
        public string FileName { get { return txtFileName.Text; } }

        public string Extensions { get { return txtExtensions.Text; } }

        public PluginSettingsForm(string fileName, string extensions)
        {
            InitializeComponent();

            fileName = Path.IsPathRooted(fileName) ? fileName : Path.Combine(AssemblyUtils.AssemblyDirectory, fileName);
            txtFileName.Text = fileName;
            txtExtensions.Text = extensions;
        }

        private void BrowseClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                RestoreDirectory = true,
                Filter = "Plugin files (*.wlx;*.wlx64)|*.wlx;*.wlx64|All files (*.*)|*.*"
            };

            if (File.Exists(txtFileName.Text))
            {
                dialog.InitialDirectory = Path.GetDirectoryName(txtFileName.Text);
            }
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dialog.FileName;
                txtExtensions.Text = string.Join(";", Plugin.GetSupportedExtensions(dialog.FileName));
            }
        }

        private void OkClick(object sender, EventArgs e)
        {
            if (!File.Exists(txtFileName.Text))
            {
                MessageBox.Show("You should select an existing file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                txtExtensions.Text.Split(';');
            }
            catch
            {
                MessageBox.Show("Extensions must be separated by semicolons.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                CancelClick(sender, (EventArgs)e);
            }
        }
    }
}
