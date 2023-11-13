using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFileName frmFileName = new frmFileName();
            frmFileName.ShowDialog();

            string getStudentNo, getProgram, getFullName, getAge, getGender, getBirthday, getContactNo;
            getStudentNo = "Student No.: " + txtStudentNo.Text;
            getProgram = "Program: " + cbProgram.Text;
            getFullName = "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text;
            getAge = "Age: " + txtAge.Text;
            getGender = "Gender: " + cbGender.Text;
            getBirthday = "Birthday: " + dateTimePicker1.Text;
            getContactNo = "Contact No.: " + txtContactNo.Text;

            string[] information = { getStudentNo, getProgram, getFullName, getAge, getGender, getBirthday, getContactNo };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName)))
            {
               foreach (string s in information)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
           {
                "BSIT",
                "BSCS",
                "BSCpE",
                "BSIS"
           };
            for (int i = 0; i < 4; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
            string[] ListOfGender = new string[]
            {
                "Male",
                "Female",
                "Prefer not to tell",
            };
            for (int x = 0; x < 3; x++)
            {
                cbGender.Items.Add(ListOfGender[x].ToString());
            }
        }
    }
}
