using POSSystemOOPFinals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace POS_System_FinalProject_Eadrian
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void ScreenTitle_Click(object sender, EventArgs e)
        {

        }
        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard formLW = new Dashboard();
            formLW.ShowDialog();
            this.Close();

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Inventory_Load(object sender, EventArgs e)
        {

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //ADD BUTTON
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            Product newProduct = new Product
            {
                Text = postDescTB.Text,
                UserName = posterNameTB.Text,
                Timestamp = postDateTB.Text,
                Handle = postURLlTB.Text,
                isVerified = verificationStatusTB.Text,
                
                productDate = productdateTimePicker.Value.ToShortDateString() //<--- di ko alam kung need mo pa neto
                //push
            };
            pDatabase.addRecords("productList", newProduct);

            invButtonS.PerformClick();
            invButtonP.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e) //UPDATE BUTTON
        {
            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Products");
            IMongoCollection<Product> records = pDatabase.GetCollection<Product>("Products");

            var recordsUpdate = Builders<Product>.Update.Set
                (p => p.isVerified, verificationStatusTB.Text).Set //<-- eto lang naman yung pwede ma update na property diba? since nga more of viewing lang etong forms na to
                (p => p.productDate, productdateTimePicker.Value.ToShortDateString()); // di ko matanggal ahahaha nag eerror
            records.UpdateOne(s => s.Id == ObjectId.Parse(postIdTB.Text), recordsUpdate);

            invButtonS.PerformClick();
            invButtonP.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)  //DELETE BUTTON
        {
            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Products");
            IMongoCollection<Product> records = pDatabase.GetCollection<Product>("productList");

            records.DeleteOne(p => p.Id == ObjectId.Parse(postIdTB.Text));
            invButtonS.PerformClick();
            invButtonP.PerformClick();
        }

        private void invSweetsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invSweetsDV_CellClick(object sender, DataGridViewCellEventArgs e) //FB CELLCLICK
        {
            postIdTB.Text = invFacebookDV.Rows[0].Cells[0].Value.ToString();
            postDescTB.Text = invFacebookDV.Rows[0].Cells[1].Value.ToString();
            postDateTB.Text = invFacebookDV.Rows[0].Cells[2].Value.ToString();
            postURLlTB.Text = invFacebookDV.Rows[0].Cells[3].Value.ToString();
            verificationStatusTB.Text = invFacebookDV.Rows[0].Cells[4].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invFacebookDV.Rows[0].Cells[5].Value.ToString());
        }

        private void invButtonS_Click(object sender, EventArgs e) //FB LOAD BUTTON
        {
            recordDatabase pDatabase = new recordDatabase("Properties");
            var records = pDatabase.checkRecords<Product>("postProperties");


            invFacebookDV.DataSource = records;
            invFacebookDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            postIdTB.Text = invFacebookDV.Rows[0].Cells[0].Value.ToString();
            postDescTB.Text = invFacebookDV.Rows[0].Cells[1].Value.ToString();
            postDateTB.Text = invFacebookDV.Rows[0].Cells[2].Value.ToString();
            postURLlTB.Text = invFacebookDV.Rows[0].Cells[3].Value.ToString();
            verificationStatusTB.Text = invFacebookDV.Rows[0].Cells[4].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invFacebookDV.Rows[0].Cells[5].Value.ToString());
        }

        private void invPastryDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invPastryDV_CellClick(object sender, DataGridViewCellEventArgs e) //Twitter CELLCLICK
        {
            postIdTB.Text = invTwitterDV.Rows[0].Cells[0].Value.ToString();
            postDescTB.Text = invTwitterDV.Rows[0].Cells[1].Value.ToString();
            postDateTB.Text = invTwitterDV.Rows[0].Cells[2].Value.ToString();
            postURLlTB.Text = invTwitterDV.Rows[0].Cells[3].Value.ToString();
            verificationStatusTB.Text = invTwitterDV.Rows[0].Cells[4].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invTwitterDV.Rows[0].Cells[5].Value.ToString());
        }

        private void invButtonP_Click(object sender, EventArgs e) // LOAD BUTTON TWITTER
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");

            invTwitterDV.DataSource = records;
            invTwitterDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //Text = postDescTB.Text,
            //UserName = postLocationTB.Text,
            //Timestamp = postDateTB.Text,
            //Handle = postURLlTB.Text,
            //isVerified = verificationStatusTB.Text,

            postIdTB.Text = invTwitterDV.Rows[0].Cells[0].Value.ToString();
            postDescTB.Text = invTwitterDV.Rows[0].Cells[1].Value.ToString();
            postDateTB.Text = invTwitterDV.Rows[0].Cells[2].Value.ToString();
            postURLlTB.Text = invTwitterDV.Rows[0].Cells[3].Value.ToString();
            verificationStatusTB.Text = invTwitterDV.Rows[0].Cells[4].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invTwitterDV.Rows[0].Cells[5].Value.ToString());
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invSweetsDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.invFacebookDV.Columns["Id"].Visible = false;
        }

        private void invPastryDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.invTwitterDV.Columns["Id"].Visible = false;
        }

        private void productQuantityTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            accessPanel formAP = new accessPanel();
            formAP.ShowDialog();
            this.Close();
        }


        private void inventoryIcon_Click(object sender, EventArgs e)
        {

        }

        private void exportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];


            if (invTabs.SelectedTab.Name == "tabSweets") //tabSweets == tabFacebook, di ko pa napapalitan yung tab name

            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Inventory Sweets";
                invButtonS.PerformClick();

                for (int i = 1; i < invFacebookDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = invFacebookDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < invFacebookDV.Rows.Count; i++)
                {
                    for (int j = 0; j < invFacebookDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = invFacebookDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsSweets-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (invTabs.SelectedTab.Name == "tabPastry")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Inventory Pastry";
                invButtonP.PerformClick();

                for (int i = 1; i < invTwitterDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = invTwitterDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < invTwitterDV.Rows.Count; i++)
                {
                    for (int j = 0; j < invTwitterDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = invTwitterDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsPastry-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }
            else 
            {
                MessageBox.Show("[!] Exporting Error.");
            }        
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            postIdTB.Text = "";
            postDescTB.Text = "";
            postDateTB.Text = "";
            postURLlTB.Text = "";
            verificationStatusTB.Text = "";          
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
