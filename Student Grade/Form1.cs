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
        float faverage = 0;

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

        //code for the calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Enter student details
            EnterDetails();
            //Calculate Average Mark
            fAverage = AverageMark(intEnglish, intMaths, intScience);
            //Calculate average Mark
            strGrade = CalculateGrade(fAverage);
            //DisplayDetails
            DisplayDetails();
        }

        //Code to clear details
        public void ClearDetails()
        {
            tbxStudentName.Text = "";
            tbxStudentNumber.Text = "";
            tbxGroup.Text = "";

            tbxEnglish.Text = "";
            txtMaths.Text = "";
            txtScience.Text = "";

            strStudentName = "";
            strStudentNumber = "";

            intEnglish = 0;
            intMaths = 0;
            intScience = 0;

            fAverage = 0;
        }

        //Code for entering student details
        public void EnterDetails()
        {
            strStudentName = tbxStudentName.Text;
            strStudentNumber = tbxStudentNumber.Text;
            strGroup = tbxGroup.Text;

            intEnglish = Convert.ToInt32(tbxEnglish.Text);
            intMaths = Convert.ToInt32(txtMaths.Text);
            intScience = Convert.ToInt32(txtScience.Text);
        }

        //code to enter Student Details
        public void DisplayDetails()
        {
            lblStudentDetailsResults.Text = strGroup + ":  " + strStudentNumber + ":  " + strStudentName;
            lblAverageMarkResult.Text = fAverage.ToString("#0.00");
            lblStudentGradeResult.Text = strGrade;
        }

        //Function to calculate Average mark
        public float AverageMark( int intNumber1, int intNumber2, int intNumber3)
        {
            float Average = (float)(intEnglish + intMaths + intScience) / 3;
            return Average;
        }

        //Function to Enter Sturent Details
        public string CalculateGrade(float Mark)
        {
            string strFinalGrade = "";
            if (Mark >=80)
            {
                strFinalGrade = "You achieved a Distinction";
            }
            else if (Mark >=60)
            {
                strFinalGrade = "You achieved a Merit";
            }
            else if (Mark >=40)
            {
                strFinalGrade = "You achieved a Pass";
            }
            else
            {
                strFinalGrade = "You must take a resit";
            }
            return strFinalGrade;
        }
        

    }
}
