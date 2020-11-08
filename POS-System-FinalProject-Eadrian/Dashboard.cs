using MongoDB.Driver;
using POS_System_FinalProject_Eadrian;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace POSSystemOOPFinals
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inventoryIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory formInventory = new Inventory();
            formInventory.ShowDialog();
            this.Close();
        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        public string eValue;
        public string aValue;
        public void employeeValue(string p)
        {
            eValue = p.ToString();
        }

        public void adminEmployeeValue(string p)
        {
            aValue = p.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://mbasic.facebook.com/EducationforNatureVietnam");
        }
      
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
           
            //recordDatabase pDatabase = new recordDatabase("EmployeeShifts");
            //var records = pDatabase.checkRecords<Workshift>("workShifts");
            //var pCategory = textBox1.Text;
            //List<Workshift> filtered = records.Where(x => x.employeeUsername == pCategory).ToList();
            //dataGridView1.DataSource = filtered;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //foreach (var record in filtered)
            //{
            //    var salary = int.Parse(textBox2.Text) + 500;
            //    textBox2.Text = salary.ToString();
            //}
            
           
        }

      
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            
            this.Hide();
            accessPanel formAP = new accessPanel();
            formAP.ShowDialog();
            this.Close();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["employeeUsername"].Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

