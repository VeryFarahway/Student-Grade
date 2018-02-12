namespace Student_Grade
{
    partial class frmStudentGrades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblEnterMarks = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.gbxResults = new System.Windows.Forms.GroupBox();
            this.lblStudentGradeResult = new System.Windows.Forms.Label();
            this.lblAverageMarkResult = new System.Windows.Forms.Label();
            this.lblStudentDetailsResults = new System.Windows.Forms.Label();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.lblAverageMark = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.tbxStudentNumber = new System.Windows.Forms.TextBox();
            this.tbxGroup = new System.Windows.Forms.TextBox();
            this.tbxEnglish = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.gbxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(543, 204);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 35);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(543, 269);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(543, 330);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(280, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 20);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Student Grades";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(30, 62);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(230, 20);
            this.lblInfo1.TabIndex = 4;
            this.lblInfo1.Text = "Please enter the student marks";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Student Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(30, 140);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(126, 20);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Student Number";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(34, 176);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(54, 20);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Group";
            // 
            // lblEnterMarks
            // 
            this.lblEnterMarks.AutoSize = true;
            this.lblEnterMarks.Location = new System.Drawing.Point(30, 219);
            this.lblEnterMarks.Name = "lblEnterMarks";
            this.lblEnterMarks.Size = new System.Drawing.Size(230, 20);
            this.lblEnterMarks.TabIndex = 8;
            this.lblEnterMarks.Text = "Please enter the student marks";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(30, 269);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(61, 20);
            this.lblEnglish.TabIndex = 9;
            this.lblEnglish.Text = "English";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(30, 305);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(53, 20);
            this.lblMaths.TabIndex = 10;
            this.lblMaths.Text = "Maths";
            // 
            // gbxResults
            // 
            this.gbxResults.Controls.Add(this.lblStudentGradeResult);
            this.gbxResults.Controls.Add(this.lblAverageMarkResult);
            this.gbxResults.Controls.Add(this.lblStudentDetailsResults);
            this.gbxResults.Controls.Add(this.lblStudentGrade);
            this.gbxResults.Controls.Add(this.lblAverageMark);
            this.gbxResults.Controls.Add(this.lblDetails);
            this.gbxResults.Location = new System.Drawing.Point(34, 381);
            this.gbxResults.Name = "gbxResults";
            this.gbxResults.Size = new System.Drawing.Size(628, 261);
            this.gbxResults.TabIndex = 11;
            this.gbxResults.TabStop = false;
            this.gbxResults.Text = "Results";
            // 
            // lblStudentGradeResult
            // 
            this.lblStudentGradeResult.AutoSize = true;
            this.lblStudentGradeResult.Location = new System.Drawing.Point(276, 132);
            this.lblStudentGradeResult.Name = "lblStudentGradeResult";
            this.lblStudentGradeResult.Size = new System.Drawing.Size(0, 20);
            this.lblStudentGradeResult.TabIndex = 18;
            // 
            // lblAverageMarkResult
            // 
            this.lblAverageMarkResult.AutoSize = true;
            this.lblAverageMarkResult.Location = new System.Drawing.Point(276, 86);
            this.lblAverageMarkResult.Name = "lblAverageMarkResult";
            this.lblAverageMarkResult.Size = new System.Drawing.Size(0, 20);
            this.lblAverageMarkResult.TabIndex = 17;
            // 
            // lblStudentDetailsResults
            // 
            this.lblStudentDetailsResults.AutoSize = true;
            this.lblStudentDetailsResults.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentDetailsResults.Location = new System.Drawing.Point(276, 43);
            this.lblStudentDetailsResults.Name = "lblStudentDetailsResults";
            this.lblStudentDetailsResults.Size = new System.Drawing.Size(0, 20);
            this.lblStudentDetailsResults.TabIndex = 16;
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Location = new System.Drawing.Point(6, 132);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(115, 20);
            this.lblStudentGrade.TabIndex = 15;
            this.lblStudentGrade.Text = "Student Grade";
            // 
            // lblAverageMark
            // 
            this.lblAverageMark.AutoSize = true;
            this.lblAverageMark.Location = new System.Drawing.Point(6, 86);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(107, 20);
            this.lblAverageMark.TabIndex = 14;
            this.lblAverageMark.Text = "Average Mark";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(6, 43);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(119, 20);
            this.lblDetails.TabIndex = 13;
            this.lblDetails.Text = "Student Details";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(30, 337);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(66, 20);
            this.lblScience.TabIndex = 12;
            this.lblScience.Text = "Science";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(314, 104);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(100, 26);
            this.tbxStudentName.TabIndex = 13;
            // 
            // tbxStudentNumber
            // 
            this.tbxStudentNumber.Location = new System.Drawing.Point(314, 140);
            this.tbxStudentNumber.Name = "tbxStudentNumber";
            this.tbxStudentNumber.Size = new System.Drawing.Size(100, 26);
            this.tbxStudentNumber.TabIndex = 14;
            // 
            // tbxGroup
            // 
            this.tbxGroup.Location = new System.Drawing.Point(314, 173);
            this.tbxGroup.Name = "tbxGroup";
            this.tbxGroup.Size = new System.Drawing.Size(100, 26);
            this.tbxGroup.TabIndex = 15;
            // 
            // tbxEnglish
            // 
            this.tbxEnglish.Location = new System.Drawing.Point(314, 263);
            this.tbxEnglish.Name = "tbxEnglish";
            this.tbxEnglish.Size = new System.Drawing.Size(100, 26);
            this.tbxEnglish.TabIndex = 16;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(314, 302);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 26);
            this.txtMaths.TabIndex = 17;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(314, 337);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(100, 26);
            this.txtScience.TabIndex = 18;
            // 
            // frmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 694);
            this.Controls.Add(this.txtScience);
            this.Controls.Add(this.txtMaths);
            this.Controls.Add(this.tbxEnglish);
            this.Controls.Add(this.tbxGroup);
            this.Controls.Add(this.tbxStudentNumber);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.lblScience);
            this.Controls.Add(this.gbxResults);
            this.Controls.Add(this.lblMaths);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblEnterMarks);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStudentGrades";
            this.Text = "Student Grades";
            this.gbxResults.ResumeLayout(false);
            this.gbxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblEnterMarks;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.GroupBox gbxResults;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblStudentGradeResult;
        private System.Windows.Forms.Label lblAverageMarkResult;
        private System.Windows.Forms.Label lblStudentDetailsResults;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.TextBox tbxStudentNumber;
        private System.Windows.Forms.TextBox tbxGroup;
        private System.Windows.Forms.TextBox tbxEnglish;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtScience;
    }
}

