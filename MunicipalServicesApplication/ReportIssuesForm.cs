using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MunicipalServicesApplication.Models;
using MunicipalServicesApplication.Services;

namespace MunicipalServicesApplication
{
    public partial class ReportIssuesForm : Form
    {
        private List<string> attachedFiles;
        private Random random;

        public ReportIssuesForm()
        {
            InitializeComponent();
            attachedFiles = new List<string>();
            random = new Random();
            LoadCategories();
            UpdateEngagementMessage();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            var categories = IssueManager.Instance.GetAvailableCategories();
            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category);
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void UpdateEngagementMessage()
        {
            string[] encouragingMessages = {
                "Your voice matters! Help us improve our community.",
                "Together we can make our municipality better!",
                "Thank you for being an active citizen!",
                "Every report helps us serve you better.",
                "Your participation makes a difference!"
            };

            lblEngagement.Text = encouragingMessages[random.Next(encouragingMessages.Length)];
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*|Images (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Documents (*.pdf;*.doc;*.docx;*.txt)|*.pdf;*.doc;*.docx;*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        if (!attachedFiles.Contains(fileName))
                        {
                            attachedFiles.Add(fileName);
                        }
                    }
                    UpdateAttachedFilesList();
                }
            }
        }

        private void UpdateAttachedFilesList()
        {
            lstAttachedFiles.Items.Clear();
            foreach (string file in attachedFiles)
            {
                lstAttachedFiles.Items.Add(Path.GetFileName(file));
            }
            lblAttachedCount.Text = $"Attached Files: {attachedFiles.Count}";
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (lstAttachedFiles.SelectedIndex >= 0)
            {
                attachedFiles.RemoveAt(lstAttachedFiles.SelectedIndex);
                UpdateAttachedFilesList();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Show progress
                progressBar.Visible = true;
                progressBar.Value = 0;

                // Simulate processing with progress updates
                for (int i = 0; i <= 100; i += 20)
                {
                    progressBar.Value = i;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(200);
                }

                // Create and save the issue
                Issue newIssue = new Issue(
                    txtLocation.Text.Trim(),
                    cmbCategory.SelectedItem.ToString(),
                    rtbDescription.Text.Trim()
                );

                // Add attached files
                foreach (string file in attachedFiles)
                {
                    newIssue.AttachedFiles.Add(file);
                }

                IssueManager.Instance.AddIssue(newIssue);

                progressBar.Value = 100;
                System.Threading.Thread.Sleep(500);

                MessageBox.Show(
                    $"Issue reported successfully!\n\nIssue ID: {newIssue.Id}\nLocation: {newIssue.Location}\nCategory: {newIssue.Category}\n\nThank you for helping improve our community!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearForm();
                progressBar.Visible = false;
                UpdateEngagementMessage();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category for the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = 0;
            rtbDescription.Clear();
            attachedFiles.Clear();
            UpdateAttachedFilesList();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearForm();
            }
        }
    }
}
