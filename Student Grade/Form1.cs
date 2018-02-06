using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade
{
    public partial class frmStudentGrades : Form
    {
        //Declaring Variables
        String strStudentName, strStudentNumber, strGroup, strGrade = "";
        int intEnglish, intMaths, intScience = 0;

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call to clear procedure
            ClearDetails();
        }

        float fAverage = 0;

        public frmStudentGrades()
        {
            InitializeComponent();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Halt();
        }

        //Code to exit
        public static void Halt()
        {
            //Local variable to store result
            DialogResult dr;

            //Accept response
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
