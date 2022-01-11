
namespace Ogrenci_Otomsyonu_VSProjesi
{
    partial class Teacher_Form
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
            this.Profile = new System.Windows.Forms.TabPage();
            this.LectureApproval = new System.Windows.Forms.TabPage();
            this.GradeEntry = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Profile);
            this.tabControl1.Controls.Add(this.LectureApproval);
            this.tabControl1.Controls.Add(this.GradeEntry);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(4, 22);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(3);
            this.Profile.Size = new System.Drawing.Size(767, 399);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profil";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // LectureApproval
            // 
            this.LectureApproval.Location = new System.Drawing.Point(4, 22);
            this.LectureApproval.Name = "LectureApproval";
            this.LectureApproval.Padding = new System.Windows.Forms.Padding(3);
            this.LectureApproval.Size = new System.Drawing.Size(767, 399);
            this.LectureApproval.TabIndex = 1;
            this.LectureApproval.Text = "Ders Onay";
            this.LectureApproval.UseVisualStyleBackColor = true;
            // 
            // GradeEntry
            // 
            this.GradeEntry.Location = new System.Drawing.Point(4, 22);
            this.GradeEntry.Name = "GradeEntry";
            this.GradeEntry.Padding = new System.Windows.Forms.Padding(3);
            this.GradeEntry.Size = new System.Drawing.Size(767, 399);
            this.GradeEntry.TabIndex = 2;
            this.GradeEntry.Text = "Not Giriş";
            this.GradeEntry.UseVisualStyleBackColor = true;
            // 
            // Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Teacher_Form";
            this.Text = "Öğretmen";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TabPage LectureApproval;
        private System.Windows.Forms.TabPage GradeEntry;
    }
}