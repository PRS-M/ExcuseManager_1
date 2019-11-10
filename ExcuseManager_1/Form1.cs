using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExcuseManager_1
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        private Excuse _currentExcuse = new Excuse();
        private string _selectedFolder = null;
        private bool _formChanged = false;

        public MainForm()
        {
            InitializeComponent();
            _currentExcuse.LastUsedDateTime = lastUsedDateTimePicker.Value;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.excuseTextBox.Text = _currentExcuse.Description;
                this.resultTextBox.Text = _currentExcuse.Result;
                this.lastUsedDateTimePicker.Value = _currentExcuse.LastUsedDateTime;
                if (!String.IsNullOrEmpty(_currentExcuse.ExcusePath))
                {
                    this.fillDateLabel.Text = File.GetLastWriteTime(_currentExcuse.ExcusePath).ToString();
                }
                this.Text = "Excuse Manager";
            }
            else
            {
                this.Text = "Excuse Manager*";
            }
            this._formChanged = changed;
        }

        private bool CheckChanged()
        {
            if (_formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = _selectedFolder;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedFolder = folderBrowserDialog.SelectedPath;
                saveButton.Enabled = true;
                openButton.Enabled = true;
                randomButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(excuseTextBox.Text) || String.IsNullOrEmpty(resultTextBox.Text))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog.InitialDirectory = _selectedFolder;
            saveFileDialog.Filter = "Text files|*.txt|All Files|*.*";
            saveFileDialog.FileName = excuseTextBox.Text + ".txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _currentExcuse.Save(saveFileDialog.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse saved");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog.InitialDirectory = _selectedFolder;
                openFileDialog.Filter = "Text files|*.txt|All files|*.*";
                openFileDialog.FileName = excuseTextBox.Text + ".txt";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _currentExcuse = new Excuse(openFileDialog.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                _currentExcuse = new Excuse(random, _selectedFolder);
                UpdateForm(false);
            }
        }

        private void excuseTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentExcuse.Description = excuseTextBox.Text;
            UpdateForm(true);
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentExcuse.Result = resultTextBox.Text;
            UpdateForm(true);
        }

        private void lastUsedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _currentExcuse.LastUsedDateTime = lastUsedDateTimePicker.Value;
            UpdateForm(true);
        }
    }
}
