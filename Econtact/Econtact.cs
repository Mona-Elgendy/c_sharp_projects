using Econtact.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        contactClass c = new contactClass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input field
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = cmdGender.Text;

            //insert data into database using our method
            bool success = c.Insert(c);
            if(success==true)
            {
                MessageBox.Show("New Contact Successfully Inserted  !");

                //call cleaer method
                Clear();
            }
            else
            {
                MessageBox.Show("Try Again");
            }

            //load data to data grid view
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;




        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            //load data to data grid view
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method to clear all fields
        public void Clear()
        {
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxContactNumber.Text = "";
            cmdGender.Text = "";
            txtBoxContactID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from the textboxes
            c.ContactID = int.Parse(txtBoxContactID.Text);
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = cmdGender.Text;

            //update data in database
            bool success = c.Update(c);
            if(success==true)
            {
                MessageBox.Show("Contact has been Updated successfully !");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update contact .Try again");
            }

            //load data to data grid view
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data grid view to text boxes
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmdGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get data from the textbox
            c.ContactID = Convert.ToInt32(txtBoxContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Contact has been Deleted successfully !");
                //refresh the data grid view

                //load data to data grid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;

                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Delete contact .Try again");
            }

           
        }
        static string myConnStr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            //get the value from the text box
            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myConnStr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName Like '%"+keyword+"%'OR LastName LIKE '%"+keyword+"%' OR ContactNo LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%' OR Gender LIKE '%"+keyword+"%'  ",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }
    }
}
