
namespace Ogrenci_Otomsyonu_VSProjesi
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username_TextB = new System.Windows.Forms.TextBox();
            this.Password_TextB = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.LoginTitle_Label = new System.Windows.Forms.Label();
            this.LoginInstruction_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_TextB
            // 
            this.Username_TextB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_TextB.Location = new System.Drawing.Point(12, 125);
            this.Username_TextB.Name = "Username_TextB";
            this.Username_TextB.Size = new System.Drawing.Size(308, 20);
            this.Username_TextB.TabIndex = 1;
            this.Username_TextB.Text = "Kullanıcı adını giriniz";
            this.Username_TextB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Username_TextB_MouseClick);
            // 
            // Password_TextB
            // 
            this.Password_TextB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_TextB.Location = new System.Drawing.Point(12, 151);
            this.Password_TextB.Name = "Password_TextB";
            this.Password_TextB.Size = new System.Drawing.Size(308, 20);
            this.Password_TextB.TabIndex = 2;
            this.Password_TextB.Text = "Şifrenizi giriniz";
            this.Password_TextB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_TextB_MouseClick);
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Login_Button.Location = new System.Drawing.Point(127, 184);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "Giriş";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // LoginTitle_Label
            // 
            this.LoginTitle_Label.AutoSize = true;
            this.LoginTitle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginTitle_Label.Location = new System.Drawing.Point(9, 9);
            this.LoginTitle_Label.Name = "LoginTitle_Label";
            this.LoginTitle_Label.Size = new System.Drawing.Size(313, 18);
            this.LoginTitle_Label.TabIndex = 4;
            this.LoginTitle_Label.Text = "Okul Otomasyon Sistemine hoşgeldinizz\r\n";
            // 
            // LoginInstruction_Label
            // 
            this.LoginInstruction_Label.AutoSize = true;
            this.LoginInstruction_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginInstruction_Label.Location = new System.Drawing.Point(12, 47);
            this.LoginInstruction_Label.Name = "LoginInstruction_Label";
            this.LoginInstruction_Label.Size = new System.Drawing.Size(228, 48);
            this.LoginInstruction_Label.TabIndex = 5;
            this.LoginInstruction_Label.Text = "Öğrenci Kullanıcı ismi      :    s(numara)\r\nÖğretmen Kullanıcı ismi  :    t(numar" +
    "a)\r\nMemur Kullanıcı ismi        :    o(numara)\r\n";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 219);
            this.Controls.Add(this.LoginInstruction_Label);
            this.Controls.Add(this.LoginTitle_Label);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_TextB);
            this.Controls.Add(this.Username_TextB);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Username_TextB;
        private System.Windows.Forms.TextBox Password_TextB;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label LoginTitle_Label;
        private System.Windows.Forms.Label LoginInstruction_Label;
    }
}

