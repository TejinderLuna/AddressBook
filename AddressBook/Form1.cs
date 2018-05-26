using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{

    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommand com = null;
        SqlDataReader read = null;
        DataTable dbdataset = null;
        String fn, ln;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void letterchanged(object sender, EventArgs e)
        {
            if (sender == txtFirstName)
            {
                Form2 f = new Form2();
                
                fn = txtFirstName.Text;
                ln = txtLastName.Text;
                dbdataset = f.show_record(fn, ln);
                addressdataGrid.DataSource = dbdataset;
                addressdataGrid.CurrentCell = null;
            }
            else if (sender == txtLastName)
            {
                Form2 f = new Form2();
                
                fn = txtFirstName.Text;
                ln = txtLastName.Text;
                dbdataset = f.show_record(fn, ln);
                addressdataGrid.DataSource = dbdataset;
                addressdataGrid.CurrentCell = null;
            }

        }

        private void rowselected(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f = null;
            if (addressdataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = addressdataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = addressdataGrid.Rows[selectedrowindex];
                f = new Form2();
                string fn = Convert.ToString(selectedRow.Cells["firstname"].Value);
                string ln= Convert.ToString(selectedRow.Cells["lastname"].Value);
                // MessageBox.Show(a+" "+b);
                f.Show();
                f.show_RecordInForm(fn, ln);
                

            }

        }

        private void itemclicked(object sender, EventArgs e)
        {
            if (sender == saveAddressMenuItem)
            {
                Form2 f = new Form2();
                f.Show();
                f.getCity_Province();
                f.disableModifyDelete();
                //this.Hide();
            }
            else if (sender == exitMenuItem)
            {
                Application.Exit();
            }
        }
        
    }
}
