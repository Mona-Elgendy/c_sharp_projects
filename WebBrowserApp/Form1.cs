using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string HomePage = Properties.Settings.Default.HomePage;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Right Reserved ", "About C# Web Browser", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NavigateToAddress(HomePage);
            AddressToolStripComboBox.Text = HomePage;
        }

        private void HomeToolStripButton_Click(object sender, EventArgs e)
        {
            
            NavigateToAddress(HomePage);
            AddressToolStripComboBox.Text = HomePage;
        }

        private void GoToolStripButton_Click(object sender, EventArgs e)
        {
            NavigateToAddress(AddressToolStripComboBox.Text);
        }

        private void AddressToolStripComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                NavigateToAddress(AddressToolStripComboBox.Text);
            }
        }

        private void NavigateToAddress(string address)
        {
            WebBrowser.Navigate(address);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }
    }
}
