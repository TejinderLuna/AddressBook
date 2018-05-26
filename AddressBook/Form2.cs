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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommand com = null;
        SqlDataReader read = null;
        DataTable dbdataset = null;
        string s;bool r;
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=empdb;Integrated Security=True");
        }
        public void getCity_Province()
        {
            con.Open();
            com = new SqlCommand("select * from province", con);
            read = com.ExecuteReader();
            while (read.Read())
            {
                cbProvince.Items.Add(read["province"].ToString());

            }
            read.Close();
            con.Close();
        }

        public bool check_validation()
        {
            bool b = false;
            
            if (txtFirst.Text == "")
            {
                MessageBox.Show("ENTER FIRST NAME");
                b = true;
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("ENTER LAST NAME");
                b = true;
            }
            else if (txtStreetNo.Text == "")
            {
                MessageBox.Show("ENTER Street no");
                b = true;
            }
            else if (txtStreetName.Text == "")
            {
                MessageBox.Show("ENTER STREET NAME");
                b = true;
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("ENTER CONTACT");
                b = true;
            }
            else if (cbProvince.Text == "")
            {
                MessageBox.Show("SELECT PROVINCE");
                b = true;
            }
            else if (cbCity.Text == "")
            {
                MessageBox.Show("SELECT CITY");
                b = true;
            }
            else if (txtPincode.Text == "")
            {
                MessageBox.Show("SELECT pincode");
                b = true;
            }

            return b;
        }
        public void reset()
        {
            txtFirst.Text = "";
            txtLast.Text = "";
            txtStreetNo.Text = "";
            txtStreetName.Text = "";
            txtContact.Text = "";
            cbProvince.SelectedIndex = -1;
            cbCity.SelectedIndex = -1;
            txtPincode.Text = "";

        }

        private void btnCLICKED(object sender, EventArgs e)
        {
            if (sender == btnSave)
            {
                bool b = check_validation();

                if (b == false)
                {
                    if (Convert.ToInt64(txtStreetNo.Text) < 0 || Convert.ToInt64(txtContact.Text) < 0)
                    {
                        MessageBox.Show("street no and CONTACT cannot be zero");
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            sda = new SqlDataAdapter("insert into address(firstname,lastname,streetno,streetname,contact,province,city,pincode)values('" + txtFirst.Text.Trim() + "','" + txtLast.Text.Trim() + "'," + txtStreetNo.Text + ",'" + txtStreetName.Text + "'," + txtContact.Text + ",'" + cbProvince.Text.ToString() + "','" + cbCity.Text.ToString() + "','" + txtPincode.Text + "')", con);
                            sda.SelectCommand.ExecuteNonQuery();
                            lblstatus.Text = "NEW ADDRESS SUCCESSFULLY SAVED";
                            reset();
                            
                        }
                        catch (System.Data.SqlClient.SqlException s)
                        {
                            MessageBox.Show("DATA already present in table with this name");
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
            else if (sender == btnRefresh)
            {
                reset();
            }
            else if (sender == btnModify)
            {
                r = check_validation();
                if (r == false)
                {
                    con.Open();
                    String query = "UPDATE  address set firstname='" + txtFirst.Text + "',lastname='" + txtLast.Text + "',streetno='" + txtStreetNo.Text + "',streetname='" + txtStreetName.Text + "',contact='" + txtContact.Text + "',province='" + cbProvince.Text.ToString() + "',city='" + cbCity.Text.ToString() + "',pincode='" + txtPincode.Text + "'where firstname='" + txtFirst.Text + "'and lastname='" + txtLast.Text + "'";
                    com = new SqlCommand(query, con);
                    com.ExecuteNonQuery();
                    lblstatus.Text = "record UPDATED";
                    con.Close();
                }
            }
            else if (sender == btnDelete)
            {
                con.Open();
                String query = "DELETE from  address where firstname='" + txtFirst.Text + "'and lastname='" + txtLast.Text +"'";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                lblstatus.Text = "record DELETED ";
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                con.Close();
            }
            
        }
        public DataTable show_record(string fn,string ln)
        {
            if (ln.Equals(""))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from address where firstname like'" + fn + "%'", con);
                // read = com.ExecuteReader();
                //sda.SelectCommand = com;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                con.Close();

               
            }
            else if (fn.Equals(""))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from address where lastname like'" + ln + "%'", con);
                // read = com.ExecuteReader();
                //sda.SelectCommand = com;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
              
                con.Close();

                
            }
            else if(fn!=null&&ln!=null)
            {
                con.Open();
                sda = new SqlDataAdapter("select * from address where firstname like'" + fn + "%'" + "and lastname like'" + ln + "%'", con);
                // read = com.ExecuteReader();
                //sda.SelectCommand = com;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                
                con.Close();

                
            }

            return dbdataset;    
            
           
        }
        public void show_RecordInForm(string fn, string ln)
        {
            btnSave.Enabled = false;
            btnSave.Visible = false;
            btnRefresh.Enabled = false;
            btnRefresh.Visible = false;
            txtFirst.Enabled = false;
            txtLast.Enabled = false;
            con.Open();
            com = new SqlCommand("select * from address where firstname like'" + fn + "'" + "and lastname like'" + ln + "'", con);
            read = com.ExecuteReader();
            if(read.Read())
             {
                 //cbcustomername.Items.Add(read["cust_name"].ToString());
                 txtFirst.Text = read["firstname"].ToString();
                 txtLast.Text = read["lastname"].ToString();
                 txtStreetNo.Text = read["streetno"].ToString();
                 txtStreetName.Text = read["streetname"].ToString();
                 txtContact.Text = read["contact"].ToString();
                 cbProvince.Text = read["province"].ToString();
                 cbCity.Text = read["city"].ToString();
                 txtPincode.Text = read["pincode"].ToString();
                 read.Close();


             }
            con.Close();
            getCity_Province();
        }

        private void alphabetspressed(object sender, KeyPressEventArgs e)
        {
            lblstatus.Text = "";
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void numberpressed(object sender, KeyPressEventArgs e)
        {
            lblstatus.Text = "";
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public void disableModifyDelete()
        {
           btnModify.Enabled = false;
           btnModify.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
        }

        private void provinceSelected(object sender, EventArgs e)
        {
            try
            {
                cbCity.Items.Clear();
                con.Open();
                com = new SqlCommand("select city from province_city where province='" + cbProvince.SelectedItem.ToString() + "'", con);
                read = com.ExecuteReader();
                while (read.Read())
                {
                    cbCity.Items.Add(read["city"].ToString());

                }
            }
            finally
            {
                con.Close();
            }

        }
    }
}
