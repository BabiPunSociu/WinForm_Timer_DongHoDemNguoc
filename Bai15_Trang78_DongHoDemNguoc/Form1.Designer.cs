namespace Bai15_Trang78_DongHoDemNguoc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiay = new System.Windows.Forms.TextBox();
            this.btnChay = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.tmrDongHo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "(Phút)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(300, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Giây)";
            // 
            // txtPhut
            // 
            this.txtPhut.BackColor = System.Drawing.Color.LightGreen;
            this.txtPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhut.Location = new System.Drawing.Point(66, 67);
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(165, 45);
            this.txtPhut.TabIndex = 0;
            this.txtPhut.Enter += new System.EventHandler(this.txtPhut_Enter);
            this.txtPhut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhut_KeyPress);
            this.txtPhut.MouseEnter += new System.EventHandler(this.txtPhut_MouseEnter);
            this.txtPhut.MouseLeave += new System.EventHandler(this.txtPhut_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(257, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // txtGiay
            // 
            this.txtGiay.BackColor = System.Drawing.Color.LightGreen;
            this.txtGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiay.Location = new System.Drawing.Point(307, 67);
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(165, 45);
            this.txtGiay.TabIndex = 1;
            this.txtGiay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhut_KeyPress);
            this.txtGiay.MouseEnter += new System.EventHandler(this.txtPhut_MouseEnter);
            this.txtGiay.MouseLeave += new System.EventHandler(this.txtPhut_MouseLeave);
            // 
            // btnChay
            // 
            this.btnChay.Location = new System.Drawing.Point(24, 169);
            this.btnChay.Name = "btnChay";
            this.btnChay.Size = new System.Drawing.Size(157, 46);
            this.btnChay.TabIndex = 2;
            this.btnChay.Text = "&Chạy";
            this.btnChay.UseVisualStyleBackColor = true;
            this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
            this.btnChay.MouseEnter += new System.EventHandler(this.btnChay_MouseEnter);
            this.btnChay.MouseLeave += new System.EventHandler(this.btnChay_MouseLeave);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(216, 169);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(157, 46);
            this.btnDung.TabIndex = 5;
            this.btnDung.Text = "&Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(405, 169);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(157, 46);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "&Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // tmrDongHo
            // 
            this.tmrDongHo.Tick += new System.EventHandler(this.tmrDongHo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(582, 237);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnChay);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồng hồ đếm ngược _ Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiay;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}

