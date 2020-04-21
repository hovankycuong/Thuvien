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
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //InitiateStudentList();
            //BindStudentList();
        }
        
        /*
         This is a function to programmarly to bind student list to the comboBox
             */
        protected void BindStudentList()
        {
            DataTable dt = new DataTable();
            string connString = @"Data Source=.;Initial Catalog=Thuvien;User ID=SqlService;Password=Abc123";
            string queryStr = @"select Name from Student";

            using(var cnn = new SqlConnection(connString))
            {
                using( var cmd = new SqlCommand(queryStr, cnn))
                {
                    cnn.Open();
                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                        if (dt != null)
                        {
                            // Bo sai order nay no se hien: system.data.dataview dialog  <--- quai
                            comboBoxStudent.DisplayMember = dt.Columns[0].ToString();
                            comboBoxStudent.ValueMember = dt.Columns[0].ToString();
                            comboBoxStudent.DataSource = dt;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    cnn.Close();
                }
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=.;Initial Catalog=Thuvien;User ID=SqlService;Password=Abc123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudent.SelectedIndex != -1)
            {
                
                string queryStr = "select Book.Title as Title, Borrow.Date as Date from Borrow left join Book on Borrow.BookID = Book.ID " +
                                    "where Borrow.StudentID = (select ID from Student where Student.Name = '" + comboBoxStudent.Text + "')";
                DataTable dt = new DataTable();
                SqlCommand borrowCmd = new SqlCommand(queryStr, new SqlConnection(Properties.Settings.Default.ThuvienConnectionString));
                SqlDataAdapter adp = new SqlDataAdapter(borrowCmd);
                adp.Fill(dt);
                dataGridViewBorrow.DataSource = dt;
                dataGridViewBorrow.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuvienDataSetStudentName.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.thuvienDataSetStudentName.Student);
            // TODO: This line of code loads data into the 'thuvienDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.thuvienDataSet.Book);

        }
    }
}
