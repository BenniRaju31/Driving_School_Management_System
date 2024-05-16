namespace ITDrivingSchoolManagementSystem
{
    partial class Form1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.buttonInstructors = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGenerateInstructorReport = new System.Windows.Forms.Button();
            this.buttonAddInstructor = new System.Windows.Forms.Button(); // Added button for adding instructor
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(70, 21);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "IT Driving School";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Location = new System.Drawing.Point(70, 47);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(106, 13);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Management System";
            // 
            // buttonInstructors
            // 
            this.buttonInstructors.Location = new System.Drawing.Point(73, 80);
            this.buttonInstructors.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInstructors.Name = "buttonInstructors";
            this.buttonInstructors.Size = new System.Drawing.Size(135, 32);
            this.buttonInstructors.TabIndex = 2;
            this.buttonInstructors.Text = "Instructors";
            this.buttonInstructors.UseVisualStyleBackColor = true;
            this.buttonInstructors.Click += new System.EventHandler(this.buttonInstructors_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(73, 135);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(135, 32);
            this.buttonStudents.TabIndex = 3;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.Location = new System.Drawing.Point(73, 191);
            this.buttonLessons.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Size = new System.Drawing.Size(135, 32);
            this.buttonLessons.TabIndex = 4;
            this.buttonLessons.Text = "Lessons";
            this.buttonLessons.UseVisualStyleBackColor = true;
            this.buttonLessons.Click += new System.EventHandler(this.buttonLessons_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.Location = new System.Drawing.Point(73, 249);
            this.buttonReports.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(135, 32);
            this.buttonReports.TabIndex = 5;
            this.buttonReports.Text = "Revenue Report";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(258, 80);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(401, 264);
            this.dataGridView.TabIndex = 6;
            // 
            // buttonGenerateInstructorReport
            // 
            this.buttonGenerateInstructorReport.Location = new System.Drawing.Point(73, 312);
            this.buttonGenerateInstructorReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateInstructorReport.Name = "buttonGenerateInstructorReport";
            this.buttonGenerateInstructorReport.Size = new System.Drawing.Size(135, 32);
            this.buttonGenerateInstructorReport.TabIndex = 7;
            this.buttonGenerateInstructorReport.Text = "Instructor Report";
            this.buttonGenerateInstructorReport.UseVisualStyleBackColor = true;
            this.buttonGenerateInstructorReport.Click += new System.EventHandler(this.buttonGenerateInstructorReport_Click);
            // 
            // buttonAddInstructor
            // 
            this.buttonAddInstructor.Location = new System.Drawing.Point(73, 371);
            this.buttonAddInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddInstructor.Name = "buttonAddInstructor";
            this.buttonAddInstructor.Size = new System.Drawing.Size(135, 32);
            this.buttonAddInstructor.TabIndex = 8;
            this.buttonAddInstructor.Text = "Add Instructor";
            this.buttonAddInstructor.UseVisualStyleBackColor = true;
            this.buttonAddInstructor.Click += new System.EventHandler(this.buttonAddInstructor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 535);
            this.Controls.Add(this.buttonAddInstructor); // Added button for adding instructor
            this.Controls.Add(this.buttonGenerateInstructorReport);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonLessons);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonInstructors);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "IT Driving School Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Button buttonInstructors;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonGenerateInstructorReport;
        private System.Windows.Forms.Button buttonAddInstructor; // Added button for adding instructor
    }
}
