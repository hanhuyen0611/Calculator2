
namespace Calculator2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH MÁY TÍNH ĐƠN GIẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số thứ 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(185, 122);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(490, 22);
            this.txtSo1.TabIndex = 1;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(185, 197);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(490, 22);
            this.txtSo2.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(185, 292);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(490, 22);
            this.txtKQ.TabIndex = 1;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(599, 373);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(76, 42);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(447, 373);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(76, 42);
            this.btTru.TabIndex = 2;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(302, 373);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(76, 42);
            this.btNhan.TabIndex = 2;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(99, 373);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(76, 42);
            this.btChia.TabIndex = 2;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
    }
}

