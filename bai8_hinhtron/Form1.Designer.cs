﻿namespace bai8_hinhtron
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
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tính diện tích hình tròn";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(121, 59);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(100, 20);
            this.txtChieuDai.TabIndex = 1;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(121, 85);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(100, 20);
            this.txtChieuRong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "chiều dài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "chiều rộng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "diện tích ht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "chu vi ht";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(121, 111);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(100, 20);
            this.txtDienTich.TabIndex = 2;
            this.txtDienTich.TextChanged += new System.EventHandler(this.txtDienTich_TextChanged);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(121, 141);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(100, 20);
            this.txtChuVi.TabIndex = 2;
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(239, 66);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(75, 23);
            this.btTinh.TabIndex = 3;
            this.btTinh.Text = "tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Button btTinh;
    }
}

