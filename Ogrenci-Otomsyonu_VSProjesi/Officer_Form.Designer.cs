
namespace Ogrenci_Otomsyonu_VSProjesi
{
    partial class Officer_Form
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
            this.OfficerTabControl = new System.Windows.Forms.TabControl();
            this.StudentAdd_Tab = new System.Windows.Forms.TabPage();
            this.TeacherAdd_Tab = new System.Windows.Forms.TabPage();
            this.LectureTeacherAssignment_Tab = new System.Windows.Forms.TabPage();
            this.OfficerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // OfficerTabControl
            // 
            this.OfficerTabControl.Controls.Add(this.StudentAdd_Tab);
            this.OfficerTabControl.Controls.Add(this.TeacherAdd_Tab);
            this.OfficerTabControl.Controls.Add(this.LectureTeacherAssignment_Tab);
            this.OfficerTabControl.Location = new System.Drawing.Point(13, 13);
            this.OfficerTabControl.Name = "OfficerTabControl";
            this.OfficerTabControl.SelectedIndex = 0;
            this.OfficerTabControl.Size = new System.Drawing.Size(775, 425);
            this.OfficerTabControl.TabIndex = 0;
            // 
            // StudentAdd_Tab
            // 
            this.StudentAdd_Tab.Location = new System.Drawing.Point(4, 22);
            this.StudentAdd_Tab.Name = "StudentAdd_Tab";
            this.StudentAdd_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentAdd_Tab.Size = new System.Drawing.Size(767, 399);
            this.StudentAdd_Tab.TabIndex = 0;
            this.StudentAdd_Tab.Text = "Öğrenci Ekleme";
            this.StudentAdd_Tab.UseVisualStyleBackColor = true;
            // 
            // TeacherAdd_Tab
            // 
            this.TeacherAdd_Tab.Location = new System.Drawing.Point(4, 22);
            this.TeacherAdd_Tab.Name = "TeacherAdd_Tab";
            this.TeacherAdd_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherAdd_Tab.Size = new System.Drawing.Size(767, 399);
            this.TeacherAdd_Tab.TabIndex = 1;
            this.TeacherAdd_Tab.Text = "Öğretmen Atama";
            this.TeacherAdd_Tab.UseVisualStyleBackColor = true;
            // 
            // LectureTeacherAssignment_Tab
            // 
            this.LectureTeacherAssignment_Tab.Location = new System.Drawing.Point(4, 22);
            this.LectureTeacherAssignment_Tab.Name = "LectureTeacherAssignment_Tab";
            this.LectureTeacherAssignment_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.LectureTeacherAssignment_Tab.Size = new System.Drawing.Size(767, 399);
            this.LectureTeacherAssignment_Tab.TabIndex = 2;
            this.LectureTeacherAssignment_Tab.Text = "Derse Öğretmen Atama";
            this.LectureTeacherAssignment_Tab.UseVisualStyleBackColor = true;
            // 
            // Officer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OfficerTabControl);
            this.Name = "Officer_Form";
            this.Text = "Memur";
            this.OfficerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OfficerTabControl;
        private System.Windows.Forms.TabPage StudentAdd_Tab;
        private System.Windows.Forms.TabPage TeacherAdd_Tab;
        private System.Windows.Forms.TabPage LectureTeacherAssignment_Tab;
    }
}