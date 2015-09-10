using System;
using System.Diagnostics;
using System.Windows.Forms;
using NPoco.iSeriesGen;

namespace NPoco.iSeriesTest
{
    public partial class FrmGenerator : Form
    {
        public FrmGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    PocoGenerator.GeneratePoco(
                        txtNamespace.Text, txtLib.Text, txtTable.Text, chkSqlSchema.Checked,
                        txtDBServer.Text, txtDBUser.Text, txtDBPassword.Text, txtDestFolder.Text);

                    if (
                        MessageBox.Show(@"Vuoi aprire la cartella di destinazione?", @"Generazione completata", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(txtDestFolder.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Check data is provided
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (String.IsNullOrEmpty(txtDBServer.Text))
            {
                MessageBox.Show(@"Inserire SERVER URL!");
                txtDBServer.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDBUser.Text))
            {
                MessageBox.Show(@"Inserire UTENTE DB!");
                txtDBUser.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDBPassword.Text))
            {
                MessageBox.Show(@"Inserire PASSWORD DB!");
                txtDBPassword.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtLib.Text))
            {
                MessageBox.Show(@"Inserire LIBRERIA!");
                txtLib.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtTable.Text))
            {
                MessageBox.Show(@"Inserire NOME TABELLA!");
                txtTable.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtNamespace.Text))
            {
                MessageBox.Show(@"Inserire NAMESPACE!");
                txtNamespace.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDestFolder.Text))
            {
                MessageBox.Show(@"Inserire CARTELLA DESTINAZIONE!");
                txtDestFolder.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Select folder with dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDestFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
