namespace ThucTapCoSo_62139022
{
    partial class SelectionSort
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Mang = new System.Windows.Forms.TextBox();
            this.button_NhapN = new System.Windows.Forms.Button();
            this.button_NhapSo = new System.Windows.Forms.Button();
            this.button_VeMang = new System.Windows.Forms.Button();
            this.button_SapXep = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_NgauNhien = new System.Windows.Forms.Button();
            this.button_SapXepGiam = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phần tử:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập phần tử:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mảng:";
            // 
            // textBox_Mang
            // 
            this.textBox_Mang.Location = new System.Drawing.Point(114, 119);
            this.textBox_Mang.Name = "textBox_Mang";
            this.textBox_Mang.Size = new System.Drawing.Size(200, 22);
            this.textBox_Mang.TabIndex = 5;
            // 
            // button_NhapN
            // 
            this.button_NhapN.Location = new System.Drawing.Point(226, 19);
            this.button_NhapN.Name = "button_NhapN";
            this.button_NhapN.Size = new System.Drawing.Size(88, 30);
            this.button_NhapN.TabIndex = 6;
            this.button_NhapN.Text = "Nhập";
            this.button_NhapN.UseVisualStyleBackColor = true;
            this.button_NhapN.Click += new System.EventHandler(this.button_NhapN_Click);
            // 
            // button_NhapSo
            // 
            this.button_NhapSo.Location = new System.Drawing.Point(226, 62);
            this.button_NhapSo.Name = "button_NhapSo";
            this.button_NhapSo.Size = new System.Drawing.Size(88, 30);
            this.button_NhapSo.TabIndex = 7;
            this.button_NhapSo.Text = "Nhập";
            this.button_NhapSo.UseVisualStyleBackColor = true;
            this.button_NhapSo.Click += new System.EventHandler(this.button_NhapSo_Click);
            // 
            // button_VeMang
            // 
            this.button_VeMang.Location = new System.Drawing.Point(392, 19);
            this.button_VeMang.Name = "button_VeMang";
            this.button_VeMang.Size = new System.Drawing.Size(139, 30);
            this.button_VeMang.TabIndex = 8;
            this.button_VeMang.Text = "Vẽ Mảng";
            this.button_VeMang.UseVisualStyleBackColor = true;
            this.button_VeMang.Click += new System.EventHandler(this.button_VeMang_Click);
            // 
            // button_SapXep
            // 
            this.button_SapXep.Location = new System.Drawing.Point(392, 66);
            this.button_SapXep.Name = "button_SapXep";
            this.button_SapXep.Size = new System.Drawing.Size(139, 30);
            this.button_SapXep.TabIndex = 9;
            this.button_SapXep.Text = "Sắp Xếp Tăng Dần";
            this.button_SapXep.UseVisualStyleBackColor = true;
            this.button_SapXep.Click += new System.EventHandler(this.button_SapXep_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(573, 66);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(139, 30);
            this.button_Xoa.TabIndex = 10;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 263);
            this.panel1.TabIndex = 12;
            // 
            // button_NgauNhien
            // 
            this.button_NgauNhien.Location = new System.Drawing.Point(573, 19);
            this.button_NgauNhien.Name = "button_NgauNhien";
            this.button_NgauNhien.Size = new System.Drawing.Size(139, 30);
            this.button_NgauNhien.TabIndex = 11;
            this.button_NgauNhien.Text = "Vẽ Ngẫu Nhiên";
            this.button_NgauNhien.UseVisualStyleBackColor = true;
            this.button_NgauNhien.Click += new System.EventHandler(this.button_NgauNhien_Click);
            // 
            // button_SapXepGiam
            // 
            this.button_SapXepGiam.Location = new System.Drawing.Point(392, 115);
            this.button_SapXepGiam.Name = "button_SapXepGiam";
            this.button_SapXepGiam.Size = new System.Drawing.Size(139, 30);
            this.button_SapXepGiam.TabIndex = 13;
            this.button_SapXepGiam.Text = "Sắp Xếp Giảm Dần";
            this.button_SapXepGiam.UseVisualStyleBackColor = true;
            this.button_SapXepGiam.Click += new System.EventHandler(this.button_SapXepGiam_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // SelectionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_SapXepGiam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_NgauNhien);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_SapXep);
            this.Controls.Add(this.button_VeMang);
            this.Controls.Add(this.button_NhapSo);
            this.Controls.Add(this.button_NhapN);
            this.Controls.Add(this.textBox_Mang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "SelectionSort";
            this.Text = "SelectionSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Mang;
        private System.Windows.Forms.Button button_NhapN;
        private System.Windows.Forms.Button button_NhapSo;
        private System.Windows.Forms.Button button_VeMang;
        private System.Windows.Forms.Button button_SapXep;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_NgauNhien;
        private System.Windows.Forms.Button button_SapXepGiam;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}