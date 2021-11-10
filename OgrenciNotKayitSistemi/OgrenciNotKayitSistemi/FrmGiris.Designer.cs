
namespace OgrenciNotKayitSistemi
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtbox_OgrenciNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası :";
            // 
            // mtbox_OgrenciNo
            // 
            this.mtbox_OgrenciNo.Location = new System.Drawing.Point(188, 81);
            this.mtbox_OgrenciNo.Mask = "0000";
            this.mtbox_OgrenciNo.Name = "mtbox_OgrenciNo";
            this.mtbox_OgrenciNo.Size = new System.Drawing.Size(100, 26);
            this.mtbox_OgrenciNo.TabIndex = 1;
            this.mtbox_OgrenciNo.ValidatingType = typeof(int);
            this.mtbox_OgrenciNo.TextChanged += new System.EventHandler(this.mtbox_OgrenciNo_TextChanged);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Location = new System.Drawing.Point(186, 113);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(102, 36);
            this.btn_GirisYap.TabIndex = 2;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(646, 227);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.mtbox_OgrenciNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbox_OgrenciNo;
        private System.Windows.Forms.Button btn_GirisYap;
    }
}

