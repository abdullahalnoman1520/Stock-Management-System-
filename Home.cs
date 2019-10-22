using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementWinApp
{
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CompanyForm companyForm = new CompanyForm();
            //companyForm.MdiParent = this;
            //companyForm.Show();
        }

        private void cetegoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CetagoryForm cetagoryForm = new CetagoryForm();
            cetagoryForm.MdiParent = this;
            cetagoryForm.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.MdiParent = this;
            itemForm.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInForm stockForm = new StockInForm();
            stockForm.MdiParent = this;
            stockForm.Show();
        }

        private void LogutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Logout?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
 
            if (result == DialogResult.Yes)
            {
                this.Hide();

                LoginForm login = new LoginForm();
                login.Show();
            }
            else
            {
                // Do something  
            }
            
        }
    }
}
