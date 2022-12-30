namespace ThucTapCoSo_62139022
{
    partial class FormMain
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
            this.button_SelectionSort = new System.Windows.Forms.Button();
            this.button_InterchangeSort = new System.Windows.Forms.Button();
            this.button_BubbleSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÔ PHỎNG THUẬT TOÁN SẮP XẾP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SelectionSort
            // 
            this.button_SelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectionSort.Location = new System.Drawing.Point(12, 241);
            this.button_SelectionSort.Name = "button_SelectionSort";
            this.button_SelectionSort.Size = new System.Drawing.Size(185, 111);
            this.button_SelectionSort.TabIndex = 1;
            this.button_SelectionSort.Text = "SELECTION SORT";
            this.button_SelectionSort.UseVisualStyleBackColor = true;
            this.button_SelectionSort.Click += new System.EventHandler(this.button_SelectionSort_Click);
            // 
            // button_InterchangeSort
            // 
            this.button_InterchangeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InterchangeSort.Location = new System.Drawing.Point(266, 241);
            this.button_InterchangeSort.Name = "button_InterchangeSort";
            this.button_InterchangeSort.Size = new System.Drawing.Size(222, 111);
            this.button_InterchangeSort.TabIndex = 2;
            this.button_InterchangeSort.Text = "INTERCHANGE SORT";
            this.button_InterchangeSort.UseVisualStyleBackColor = true;
            this.button_InterchangeSort.Click += new System.EventHandler(this.button_InterchangeSort_Click);
            // 
            // button_BubbleSort
            // 
            this.button_BubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BubbleSort.Location = new System.Drawing.Point(539, 241);
            this.button_BubbleSort.Name = "button_BubbleSort";
            this.button_BubbleSort.Size = new System.Drawing.Size(222, 111);
            this.button_BubbleSort.TabIndex = 3;
            this.button_BubbleSort.Text = "BUBBLE SORT";
            this.button_BubbleSort.UseVisualStyleBackColor = true;
            this.button_BubbleSort.Click += new System.EventHandler(this.button_BubbleSort_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_BubbleSort);
            this.Controls.Add(this.button_InterchangeSort);
            this.Controls.Add(this.button_SelectionSort);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SelectionSort;
        private System.Windows.Forms.Button button_InterchangeSort;
        private System.Windows.Forms.Button button_BubbleSort;
    }
}

