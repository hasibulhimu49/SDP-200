using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Sellings : Form
    {
        public Sellings()
        {
            InitializeComponent();
            ShowMedicine();
            ShowBill();
            GetCustomer();
            LblSellerName.Text = Login.User;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Pharmacy Management System\Pharmacy Management System\PharmacyDB.mdf;Integrated Security=True");
        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSellerName_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerId from CustomerTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Load(Rdr);
            txtCustomerId.ValueMember = "CustomerId";
            txtCustomerId.DataSource = dt;
            con.Close();
        }
        private void GetCustomerName()
        {
            con.Open();
            string Query = "Select * from CustomerTbl Where CustomerId='" + txtCustomerId.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtCustomerName.Text = dr["CustomerName"].ToString();
            }
            con.Close();
        }
        private void UpdateQnty()
        {
            try
            {
                int NewQnty = Stock - Convert.ToInt32(txtQuantity.Text);
                con.Open();
                //SqlCommand cmd = new SqlCommand("Update MedicineTbl Set MedicineId=@MKey", con);
                //SqlCommand cmd = new SqlCommand("Update MedicineTbl Set Quantity=@MQ WHERE MedicineId=@MKey", con);
                SqlCommand cmd = new SqlCommand("Update MedicineTbl Set MedicineQnty=@MQ WHERE MedicineId=@MKey", con);


                cmd.Parameters.AddWithValue("@MQ", NewQnty);
                cmd.Parameters.AddWithValue("@MKey", Key);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Medicine Update Successfully");
                MessageBox.Show("Added Successfully");
                con.Close();
                ShowMedicine();
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }
        private void ShowBill()
        {
            con.Open();
            string Query = "Select * from BillTbl Where SellerName='" + LblSellerName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            //DGVTransactions.DataSource = ds.Tables[0];  
            con.Close();
        }
        private void ShowMedicine()
        {
            con.Open();
            string Query = "Select * from MedicineTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DGVMedicineLists.DataSource = ds.Tables[0];
            con.Close();
        }
        int n = 0, GrdTotal = 0;
        int Key = 0, Stock;
        int MedId, MedPrice, MedQty, MedTot;
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if (txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text) > Stock)
            {
                MessageBox.Show("Enter Correct Quantity");
            }

            else
            {
                int total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DGVBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = textMedicine.Text;
                newRow.Cells[2].Value = txtQuantity.Text;
                newRow.Cells[3].Value = txtPrice.Text;
                newRow.Cells[4].Value = total;
                DGVBill.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                LblTotal.Text = "BDT" + GrdTotal;
                n++;
                UpdateQnty();

            }*/
            /*if (string.IsNullOrEmpty(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out int quantity) || quantity > Stock)
            {
                MessageBox.Show("Enter a correct Quantity.");
            }
            else if (!int.TryParse(txtPrice.Text, out int price))
            {
                MessageBox.Show("Enter a valid Price.");
            }
            else
            {
                int total = quantity * price;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DGVBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = textMedicine.Text;
                newRow.Cells[2].Value = quantity;
                newRow.Cells[3].Value = price;
                newRow.Cells[4].Value = total;
                DGVBill.Rows.Add(newRow);
                GrdTotal += total;
                LblTotal.Text = "BDT  " + GrdTotal;
                n++;
                UpdateQnty();
            }*/
            if (string.IsNullOrEmpty(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out int quantity) || quantity > Stock)
            {
                MessageBox.Show("Enter a correct Quantity.");
            }
            else if (!int.TryParse(txtPrice.Text, out int price))
            {
                MessageBox.Show("Enter a valid Price.");
            }
            else
            {
                int total = quantity * price;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DGVBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = textMedicine.Text;
                newRow.Cells[2].Value = quantity;
                newRow.Cells[3].Value = price;
                newRow.Cells[4].Value = total;
                DGVBill.Rows.Add(newRow);
                GrdTotal += total;
                LblTotal.Text = "BDT " + GrdTotal;
                n++;

                // Reduce stock quantity in your data source (e.g., database or in-memory data structure)
                ReduceStock(textMedicine.Text, quantity);

                UpdateQnty();
            }
        }
        private void ReduceStock(string medicineName, int quantity)
        {
            // In this method, you should update the stock quantity in your data source.
            // Implement the logic to find and update the stock for the given 'medicineName' with 'quantity'.

            // Example (assuming you have a database):
            // using (SqlConnection con = new SqlConnection("your_connection_string_here"))

            /* SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Pharmacy Management System\Pharmacy Management System\PharmacyDB.mdf;Integrated Security=True");
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("UPDATE MedicineTbl SET MedicineQnty = MedicineQnty - @Quantity WHERE MedicineName = @MedicineName", con);
                 cmd.Parameters.AddWithValue("@Quantity", quantity);
                 cmd.Parameters.AddWithValue("@MedicineName", medicineName);
                 cmd.ExecuteNonQuery();
                 con.Close();
             }*/
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Pharmacy Management System\Pharmacy Management System\PharmacyDB.mdf;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE MedicineTbl SET Quantity = Quantity - @Quantity WHERE MedicineName = @MedicineName", con);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@MedicineName", medicineName);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close(); // Close the connection in a finally block.
                }
            }
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Sellings_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void GoDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void btnManufacturar_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

        private void GoManufacturar_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            this.Hide();
            obj.Show();
        }

        private void GoMedicines_Click(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            this.Hide();
            obj.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void GoCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
            this.Hide();
            obj.Show();
        }
        String MedName;
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MIRPUR PHARMACY", new Font("Babes Neue", 22, FontStyle.Bold), Brushes.Black, new Point(290,10));
            e.Graphics.DrawString("ID Medicine Price Quantity Total", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(10,Pos +22));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Consolas", 10, FontStyle.Regular), Brushes.Black, new Point(10,Pos + 06));
            foreach (DataGridViewRow row in DGVBill.Rows)
            {
                MedId = Convert.ToInt32(row.Cells["id"].Value);
                MedName = "" + row.Cells["meds"].Value;
                MedPrice = Convert.ToInt32(row.Cells["qty"].Value);
                MedQty = Convert.ToInt32(row.Cells["price"].Value);
                MedTot = Convert.ToInt32(row.Cells["total"].Value);

                 e.Graphics.DrawString("" + MedId, new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(22, Pos+40));
                 e.Graphics.DrawString("" + MedName, new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(51, Pos+40));
                 e.Graphics.DrawString("" + MedPrice, new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(134, Pos+40));
                 e.Graphics.DrawString("" + MedQty, new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(176, Pos+40));
                 e.Graphics.DrawString("" + MedTot, new Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, new Point(241, Pos+40));
                 Pos = Pos + 20;
            }
            e.Graphics.DrawString("Grand Total: BDT  " + GrdTotal, new Font("Century Gothic", 13, FontStyle.Regular), Brushes.Black, new Point(50, Pos + 50));
            e.Graphics.DrawString("**********  THANK YOU  **********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(290, Pos + 200));
            DGVBill.Rows.Clear();
            DGVBill.Refresh();
            Pos = 100;
            GrdTotal = 0;
            n = 0;
        }

        private void DGVMedicineList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textMedicine.Text = DGVMedicineLists.SelectedRows[0].Cells[1].Value.ToString();
            //txtMedicineType.SelectedItem = DGVMedicineStock.SlectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(DGVMedicineLists.SelectedRows[0].Cells[3].Value.ToString());
            txtPrice.Text = DGVMedicineLists.SelectedRows[0].Cells[4].Value.ToString();
            //txtManufacturer.Selectedvalue = DGVMedicineStock.SlectedRows[0].Cells[5].Value.ToString();
            //txtManufacturerName.Text = DGVMedicineStock.SlectedRows[0].Cells[6].Value.ToString();
            if(textMedicine.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVMedicineLists.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        int Pos = 60;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Sellings obj = new Sellings();
            this.Hide();
            obj.Show();
        }

        private void DGVTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void DGVBill_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVBill.Rows.Count == 0)
            {
                MessageBox.Show("The bill is empty. Add items to the bill before assigning.");
                return;
            }

           // using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Pharmacy Management System\\Pharmacy Management System\\PharmacyDB.mdf;Integrated Security=True\"))
            {
                con.Open();

                // 1. Save the bill details to your database.
                SqlCommand cmd = new SqlCommand("INSERT INTO BillTbl (SellerName, TotalAmount, BillDate) VALUES (@SellerName, @TotalAmount, @BillDate)", con);
                cmd.Parameters.AddWithValue("@SellerName", LblSellerName.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", GrdTotal);
                cmd.Parameters.AddWithValue("@BillDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                // 2. Get the ID of the newly inserted bill.
                int billId = 0;
                SqlCommand getIdCmd = new SqlCommand("SELECT SCOPE_IDENTITY() AS BillId", con);
                SqlDataReader reader = getIdCmd.ExecuteReader();
                if (reader.Read())
                {
                    billId = Convert.ToInt32(reader["BillId"]);
                }

                // 3. Save the individual bill items to your database.
                foreach (DataGridViewRow row in DGVBill.Rows)
                {
                    string medicineName = row.Cells[1].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[2].Value);
                    int price = Convert.ToInt32(row.Cells[3].Value);
                    int total = Convert.ToInt32(row.Cells[4].Value);

                    SqlCommand itemCmd = new SqlCommand("INSERT INTO BillItems (BillId, MedicineName, Quantity, Price, TotalAmount) VALUES (@BillId, @MedicineName, @Quantity, @Price, @TotalAmount)", con);
                    itemCmd.Parameters.AddWithValue("@BillId", billId);
                    itemCmd.Parameters.AddWithValue("@MedicineName", medicineName);
                    itemCmd.Parameters.AddWithValue("@Quantity", quantity);
                    itemCmd.Parameters.AddWithValue("@Price", price);
                    itemCmd.Parameters.AddWithValue("@TotalAmount", total);
                    itemCmd.ExecuteNonQuery();
                }

                // 4. Clear the bill in your application.
                DGVBill.Rows.Clear();
                GrdTotal = 0;
                LblTotal.Text = "Total BDT  0";

                con.Close();

                MessageBox.Show("Bill assigned successfully.");
            }
        }

        private void textMedicine_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintPreviewDialog_Load(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoSeller_Click(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
            this.Hide();
            obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void GoLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
       // int n = 0,GrdTotal = 0;
       // int Key = 0, Stock;
       // int MedId, MedPrice, MedQty, MedTot;
        private void txtCustomerId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustomerName();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
