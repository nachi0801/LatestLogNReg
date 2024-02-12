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

namespace Login_nd_Reg_Form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=D:\\Dacoco-Login-and-Reg-Form\\Login-nd-Reg-Form\\Login-nd-Reg-Form\\LogNRegDataSet.xsd");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Accounts values (@FirstName, @LastName, @Email, @ContactNum, @Username, @Password, @ConPass)", conn);
            cmd.Parameters.AddWithValue("@FirstName", Fname.Text);
            cmd.Parameters.AddWithValue("@LastName", Lname.Text);
            cmd.Parameters.AddWithValue("@Email", Eadd.Text);
            cmd.Parameters.AddWithValue("@ContactNum", int.Parse(Cnum.Text));
            cmd.Parameters.AddWithValue("@Username", Uname.Text);
            cmd.Parameters.AddWithValue("@Password", Pass.Text);
            cmd.Parameters.AddWithValue("@ConPass", Cpass.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Added!");
        }
    }
}
