namespace ThucTapCoSo_62139022
{
    partial class BubbleSort
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_NgauNhien = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_SapXep = new System.Windows.Forms.Button();
            this.button_VeMang = new System.Windows.Forms.Button();
            this.button_NhapSo = new System.Windows.Forms.Button();
            this.button_NhapN = new System.Windows.Forms.Button();
            this.textBox_Mang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button_SapXepGiam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 263);
            this.panel1.TabIndex = 25;
            // 
            // button_NgauNhien
            // 
            this.button_NgauNhien.Location = new System.Drawing.Point(582, 23);
            this.button_NgauNhien.Name = "button_NgauNhien";
            this.button_NgauNhien.Size = new System.Drawing.Size(139, 30);
            this.button_NgauNhien.TabIndex = 24;
            this.button_NgauNhien.Text = "Vẽ Ngẫu Nhiên";
            this.button_NgauNhien.UseVisualStyleBackColor = true;
            this.button_NgauNhien.Click += new System.EventHandler(this.button_NgauNhien_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(582, 66);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(139, 30);
            this.button_Xoa.TabIndex = 23;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_SapXep
            // 
            this.button_SapXep.Location = new System.Drawing.Point(401, 66);
            this.button_SapXep.Name = "button_SapXep";
            this.button_SapXep.Size = new System.Drawing.Size(139, 30);
            this.button_SapXep.TabIndex = 22;
            this.button_SapXep.Text = "Sắp Xếp Tăng Dần";
            this.button_SapXep.UseVisualStyleBackColor = true;
            this.button_SapXep.Click += new System.EventHandler(this.button_SapXep_Click);
            // 
            // button_VeMang
            // 
            this.button_VeMang.Location = new System.Drawing.Point(401, 23);
            this.button_VeMang.Name = "button_VeMang";
            this.button_VeMang.Size = new System.Drawing.Size(139, 30);
            this.button_VeMang.TabIndex = 21;
            this.button_VeMang.Text = "Vẽ Mảng";
            this.button_VeMang.UseVisualStyleBackColor = true;
            this.button_VeMang.Click += new System.EventHandler(this.button_VeMang_Click);
            // 
            // button_NhapSo
            // 
            this.button_NhapSo.Location = new System.Drawing.Point(235, 66);
            this.button_NhapSo.Name = "button_NhapSo";
            this.button_NhapSo.Size = new System.Drawing.Size(88, 30);
            this.button_NhapSo.TabIndex = 20;
            this.button_NhapSo.Text = "Nhập";
            this.button_NhapSo.UseVisualStyleBackColor = true;
            this.button_NhapSo.Click += new System.EventHandler(this.button_NhapSo_Click);
            // 
            // button_NhapN
            // 
            this.button_NhapN.Location = new System.Drawing.Point(235, 23);
            this.button_NhapN.Name = "button_NhapN";
            this.button_NhapN.Size = new System.Drawing.Size(88, 30);
            this.button_NhapN.TabIndex = 19;
            this.button_NhapN.Text = "Nhập";
            this.button_NhapN.UseVisualStyleBackColor = true;
            this.button_NhapN.Click += new System.EventHandler(this.button_NhapN_Click);
            // 
            // textBox_Mang
            // 
            this.textBox_Mang.Location = new System.Drawing.Point(123, 123);
            this.textBox_Mang.Name = "textBox_Mang";
            this.textBox_Mang.Size = new System.Drawing.Size(200, 22);
            this.textBox_Mang.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mảng:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhập phần tử:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số phần tử:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 13;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // button_SapXepGiam
            // 
            this.button_SapXepGiam.Location = new System.Drawing.Point(401, 112);
            this.button_SapXepGiam.Name = "button_SapXepGiam";
            this.button_SapXepGiam.Size = new System.Drawing.Size(139, 30);
            this.button_SapXepGiam.TabIndex = 26;
            this.button_SapXepGiam.Text = "Sắp Xếp Giảm Dần";
            this.button_SapXepGiam.UseVisualStyleBackColor = true;
            this.button_SapXepGiam.Click += new System.EventHandler(this.button_SapXepGiam_Click);
            // 
            // BubbleSort
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
            this.Name = "BubbleSort";
            this.Text = "BubbleSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_NgauNhien;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_SapXep;
        private System.Windows.Forms.Button button_VeMang;
        private System.Windows.Forms.Button button_NhapSo;
        private System.Windows.Forms.Button button_NhapN;
        private System.Windows.Forms.TextBox textBox_Mang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button_SapXepGiam;
    }
}