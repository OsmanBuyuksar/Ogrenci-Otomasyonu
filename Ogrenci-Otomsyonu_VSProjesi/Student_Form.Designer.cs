
namespace Ogrenci_Otomsyonu_VSProjesi
{
    partial class Student_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Grade_Tab = new System.Windows.Forms.TabPage();
            this.YearSelection_ListBox = new System.Windows.Forms.ListBox();
            this.StudentSurname_Label = new System.Windows.Forms.Label();
            this.StudentName_Label = new System.Windows.Forms.Label();
            this.GradeList_Button = new System.Windows.Forms.Button();
            this.LectureTableTitle_Label = new System.Windows.Forms.Label();
            this.StudentScreen_DataG = new System.Windows.Forms.DataGridView();
            this.LectureAssignment_Tab = new System.Windows.Forms.TabPage();
            this.LectureSelection_Button = new System.Windows.Forms.Button();
            this.Lectures = new System.Windows.Forms.TabPage();
            this.ListLectures_Button = new System.Windows.Forms.Button();
            this.YearSelect_Label = new System.Windows.Forms.Label();
            this.SemesterSelection_Label = new System.Windows.Forms.Label();
            this.SemesterSelection_ListB = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Grade_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentScreen_DataG)).BeginInit();
            this.LectureAssignment_Tab.SuspendLayout();
            this.Lectures.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Grade_Tab);
            this.tabControl1.Controls.Add(this.LectureAssignment_Tab);
            this.tabControl1.Controls.Add(this.Lectures);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // Grade_Tab
            // 
            this.Grade_Tab.Controls.Add(this.SemesterSelection_ListB);
            this.Grade_Tab.Controls.Add(this.SemesterSelection_Label);
            this.Grade_Tab.Controls.Add(this.YearSelect_Label);
            this.Grade_Tab.Controls.Add(this.YearSelection_ListBox);
            this.Grade_Tab.Controls.Add(this.StudentSurname_Label);
            this.Grade_Tab.Controls.Add(this.StudentName_Label);
            this.Grade_Tab.Controls.Add(this.GradeList_Button);
            this.Grade_Tab.Controls.Add(this.LectureTableTitle_Label);
            this.Grade_Tab.Controls.Add(this.StudentScreen_DataG);
            this.Grade_Tab.Location = new System.Drawing.Point(4, 22);
            this.Grade_Tab.Name = "Grade_Tab";
            this.Grade_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Grade_Tab.Size = new System.Drawing.Size(788, 407);
            this.Grade_Tab.TabIndex = 0;
            this.Grade_Tab.Text = "Notlar";
            this.Grade_Tab.UseVisualStyleBackColor = true;
            this.Grade_Tab.Click += new System.EventHandler(this.Grade_Tab_Click);
            // 
            // YearSelection_ListBox
            // 
            this.YearSelection_ListBox.FormattingEnabled = true;
            this.YearSelection_ListBox.Location = new System.Drawing.Point(35, 84);
            this.YearSelection_ListBox.Name = "YearSelection_ListBox";
            this.YearSelection_ListBox.Size = new System.Drawing.Size(48, 30);
            this.YearSelection_ListBox.TabIndex = 15;
            // 
            // StudentSurname_Label
            // 
            this.StudentSurname_Label.AutoSize = true;
            this.StudentSurname_Label.Location = new System.Drawing.Point(6, 50);
            this.StudentSurname_Label.Name = "StudentSurname_Label";
            this.StudentSurname_Label.Size = new System.Drawing.Size(42, 13);
            this.StudentSurname_Label.TabIndex = 14;
            this.StudentSurname_Label.Text = "Soyisim";
            // 
            // StudentName_Label
            // 
            this.StudentName_Label.AutoSize = true;
            this.StudentName_Label.Location = new System.Drawing.Point(6, 26);
            this.StudentName_Label.Name = "StudentName_Label";
            this.StudentName_Label.Size = new System.Drawing.Size(24, 13);
            this.StudentName_Label.TabIndex = 13;
            this.StudentName_Label.Text = "isim";
            // 
            // GradeList_Button
            // 
            this.GradeList_Button.Location = new System.Drawing.Point(628, 115);
            this.GradeList_Button.Name = "GradeList_Button";
            this.GradeList_Button.Size = new System.Drawing.Size(131, 23);
            this.GradeList_Button.TabIndex = 12;
            this.GradeList_Button.Text = "Notları Listele";
            this.GradeList_Button.UseVisualStyleBackColor = true;
            this.GradeList_Button.Click += new System.EventHandler(this.GradeList_Button_Click);
            // 
            // LectureTableTitle_Label
            // 
            this.LectureTableTitle_Label.AutoSize = true;
            this.LectureTableTitle_Label.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LectureTableTitle_Label.Location = new System.Drawing.Point(3, 126);
            this.LectureTableTitle_Label.Name = "LectureTableTitle_Label";
            this.LectureTableTitle_Label.Size = new System.Drawing.Size(71, 27);
            this.LectureTableTitle_Label.TabIndex = 9;
            this.LectureTableTitle_Label.Text = "Notlar";
            // 
            // StudentScreen_DataG
            // 
            this.StudentScreen_DataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentScreen_DataG.Location = new System.Drawing.Point(-2, 156);
            this.StudentScreen_DataG.Name = "StudentScreen_DataG";
            this.StudentScreen_DataG.Size = new System.Drawing.Size(798, 258);
            this.StudentScreen_DataG.TabIndex = 8;
            // 
            // LectureAssignment_Tab
            // 
            this.LectureAssignment_Tab.Controls.Add(this.LectureSelection_Button);
            this.LectureAssignment_Tab.Location = new System.Drawing.Point(4, 22);
            this.LectureAssignment_Tab.Name = "LectureAssignment_Tab";
            this.LectureAssignment_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.LectureAssignment_Tab.Size = new System.Drawing.Size(788, 407);
            this.LectureAssignment_Tab.TabIndex = 1;
            this.LectureAssignment_Tab.Text = "Ders Kaydı";
            this.LectureAssignment_Tab.UseVisualStyleBackColor = true;
            // 
            // LectureSelection_Button
            // 
            this.LectureSelection_Button.Location = new System.Drawing.Point(329, 192);
            this.LectureSelection_Button.Name = "LectureSelection_Button";
            this.LectureSelection_Button.Size = new System.Drawing.Size(131, 23);
            this.LectureSelection_Button.TabIndex = 12;
            this.LectureSelection_Button.Text = "Ders Kaydı Yap";
            this.LectureSelection_Button.UseVisualStyleBackColor = true;
            // 
            // Lectures
            // 
            this.Lectures.Controls.Add(this.ListLectures_Button);
            this.Lectures.Location = new System.Drawing.Point(4, 22);
            this.Lectures.Name = "Lectures";
            this.Lectures.Padding = new System.Windows.Forms.Padding(3);
            this.Lectures.Size = new System.Drawing.Size(788, 407);
            this.Lectures.TabIndex = 2;
            this.Lectures.Text = "Alınan Dersler";
            this.Lectures.UseVisualStyleBackColor = true;
            // 
            // ListLectures_Button
            // 
            this.ListLectures_Button.Location = new System.Drawing.Point(329, 192);
            this.ListLectures_Button.Name = "ListLectures_Button";
            this.ListLectures_Button.Size = new System.Drawing.Size(131, 23);
            this.ListLectures_Button.TabIndex = 11;
            this.ListLectures_Button.Text = "Alınan Dersleri Listele";
            this.ListLectures_Button.UseVisualStyleBackColor = true;
            // 
            // YearSelect_Label
            // 
            this.YearSelect_Label.AutoSize = true;
            this.YearSelect_Label.Location = new System.Drawing.Point(11, 84);
            this.YearSelect_Label.Name = "YearSelect_Label";
            this.YearSelect_Label.Size = new System.Drawing.Size(21, 13);
            this.YearSelect_Label.TabIndex = 16;
            this.YearSelect_Label.Text = "Yıl:";
            // 
            // SemesterSelection_Label
            // 
            this.SemesterSelection_Label.AutoSize = true;
            this.SemesterSelection_Label.Location = new System.Drawing.Point(89, 84);
            this.SemesterSelection_Label.Name = "SemesterSelection_Label";
            this.SemesterSelection_Label.Size = new System.Drawing.Size(37, 13);
            this.SemesterSelection_Label.TabIndex = 17;
            this.SemesterSelection_Label.Text = "Yarıyıl:";
            // 
            // SemesterSelection_ListB
            // 
            this.SemesterSelection_ListB.FormattingEnabled = true;
            this.SemesterSelection_ListB.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.SemesterSelection_ListB.Location = new System.Drawing.Point(132, 84);
            this.SemesterSelection_ListB.Name = "SemesterSelection_ListB";
            this.SemesterSelection_ListB.Size = new System.Drawing.Size(48, 30);
            this.SemesterSelection_ListB.TabIndex = 18;
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "Student_Form";
            this.Text = "Öğrenci";
            this.tabControl1.ResumeLayout(false);
            this.Grade_Tab.ResumeLayout(false);
            this.Grade_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentScreen_DataG)).EndInit();
            this.LectureAssignment_Tab.ResumeLayout(false);
            this.Lectures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Grade_Tab;
        private System.Windows.Forms.ListBox YearSelection_ListBox;
        private System.Windows.Forms.Label StudentSurname_Label;
        private System.Windows.Forms.Label StudentName_Label;
        private System.Windows.Forms.Button GradeList_Button;
        private System.Windows.Forms.Label LectureTableTitle_Label;
        private System.Windows.Forms.DataGridView StudentScreen_DataG;
        private System.Windows.Forms.TabPage LectureAssignment_Tab;
        private System.Windows.Forms.Button LectureSelection_Button;
        private System.Windows.Forms.TabPage Lectures;
        private System.Windows.Forms.Button ListLectures_Button;
        private System.Windows.Forms.ListBox SemesterSelection_ListB;
        private System.Windows.Forms.Label SemesterSelection_Label;
        private System.Windows.Forms.Label YearSelect_Label;
    }
}