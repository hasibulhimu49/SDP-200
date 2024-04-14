using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pharmacy_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountMedicine();
            CountCustomer();
            Countseller();
            SumAmount();
            //GetSeller();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Pharmacy Management System\Pharmacy Management System\PharmacyDB.mdf;Integrated Security=True");
        private void CountMedicine()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from MedicineTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblMedicine.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountCustomer()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CustomerTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblCustomer.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void Countseller()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SellerTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellers.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void SumAmount()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BillAmount) from BillTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           // LblSellAmount.Text ="BDT " + dt.Rows[0][0].ToString();
            con.Close();
        }
       
       /* private void GetSeller()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select SellerName from SellerTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SellerName", typeof(string));
            dt.Load(Rdr);
            txtSellsBySeller.ValueMember = "SelectName";
            txtSellsBySeller.DataSource = dt;
            con.Close();
        }*/
        /*private void GetBestCustomer()
        {
            try
            {
                con.Open();
                String InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);
                string Query = "select CustomerName from BillTbl where BillAmount ='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
        }*/
        /*private void GetBestSeller()
        {
            try
            {
                con.Open();
                String InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);
                string Query = "select sellerName from BillTbl where BillAmount ='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sellings obj = new Sellings();
            this.Hide();
            obj.Show();
        }

        private void LblBestSeller_Click(object sender, EventArgs e)
        {

        }

        private void LblBestCustomer_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoManufacturar_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

        private void GoMedicines_Click(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            this.Hide();
            obj.Show();
        }

        private void GoCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void GoSeller_Click(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
            this.Hide();
            obj.Show();
        }

        private void GoSellers_Click(object sender, EventArgs e)
        {
            Sellings obj = new Sellings();
            this.Hide();
            obj.Show();
        }

        private void GoLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

       

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void LblSellers_Click(object sender, EventArgs e)
        {
           
        }

        private void LblCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void LblMedicine_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click_2(object sender, EventArgs e)
        {
            
        }

    }
}
