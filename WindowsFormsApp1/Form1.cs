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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3ORFC25\\MSSQLSERVER01;Initial Catalog=WindowsFormsAppDb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            List<string> selectedLang = new List<string>();
            if (checkSetswana.Chekeced)
            {
                selectedLang.Add("Setswana");
            }
            if (checkEnglish.Checked)
            {
                selectedLang.Add("English");
            }
            if (checkIsizulu.Checked)
            {
                selectedLang.Add("Isizulu");
            }
            if (checkAfrikaans.Checked)
            {
                selectedLang.Add("Afrikaans");
            }

            string languages = String.Join(",", selectedLang);

            con.Open();
            using (SqlCommand cmd= new SqlCommand("dbo.SP_Student_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Full_Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Index_no", txtIndexNumber.Text);
                cmd.Parameters.AddWithValue("@Aca_year", comAcademicYear.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", calDOB.Value);
                cmd.Parameters.AddWithValue("@Language", languages);
                cmd.ExecuteNonQuery();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
