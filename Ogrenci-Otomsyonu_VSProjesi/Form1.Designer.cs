
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
            this.SuspendLayout();
            // 
            // Username_TextB
            // 
            this.Username_TextB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_TextB.Location = new System.Drawing.Point(12, 12);
            this.Username_TextB.Name = "Username_TextB";
            this.Username_TextB.Size = new System.Drawing.Size(202, 20);
            this.Username_TextB.TabIndex = 1;
            this.Username_TextB.Text = "Kullanıcı adını giriniz";
            this.Username_TextB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password_TextB
            // 
            this.Password_TextB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_TextB.Location = new System.Drawing.Point(12, 38);
            this.Password_TextB.Name = "Password_TextB";
            this.Password_TextB.Size = new System.Drawing.Size(202, 20);
            this.Password_TextB.TabIndex = 2;
            this.Password_TextB.Text = "Şifrenizi giriniz";
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Login_Button.Location = new System.Drawing.Point(75, 69);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "Giriş";
            this.Login_Button.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 103);
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
    }
}

