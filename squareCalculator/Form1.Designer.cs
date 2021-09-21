
namespace squareCalculator
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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_startNum = new System.Windows.Forms.Label();
            this.lbl_stopNum = new System.Windows.Forms.Label();
            this.txt_startNum = new System.Windows.Forms.TextBox();
            this.txt_stopNum = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(36, 27);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(99, 57);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate Squares";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_startNum
            // 
            this.lbl_startNum.AutoSize = true;
            this.lbl_startNum.Location = new System.Drawing.Point(166, 27);
            this.lbl_startNum.Name = "lbl_startNum";
            this.lbl_startNum.Size = new System.Drawing.Size(52, 16);
            this.lbl_startNum.TabIndex = 1;
            this.lbl_startNum.Text = "Start at:";
            // 
            // lbl_stopNum
            // 
            this.lbl_stopNum.AutoSize = true;
            this.lbl_stopNum.Location = new System.Drawing.Point(166, 68);
            this.lbl_stopNum.Name = "lbl_stopNum";
            this.lbl_stopNum.Size = new System.Drawing.Size(53, 16);
            this.lbl_stopNum.TabIndex = 2;
            this.lbl_stopNum.Text = "Stop at:";
            // 
            // txt_startNum
            // 
            this.txt_startNum.Location = new System.Drawing.Point(251, 27);
            this.txt_startNum.Name = "txt_startNum";
            this.txt_startNum.Size = new System.Drawing.Size(100, 22);
            this.txt_startNum.TabIndex = 3;
            // 
            // txt_stopNum
            // 
            this.txt_stopNum.Location = new System.Drawing.Point(251, 68);
            this.txt_stopNum.Name = "txt_stopNum";
            this.txt_stopNum.Size = new System.Drawing.Size(100, 22);
            this.txt_stopNum.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(36, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 388);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 576);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_stopNum);
            this.Controls.Add(this.txt_startNum);
            this.Controls.Add(this.lbl_stopNum);
            this.Controls.Add(this.lbl_startNum);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_startNum;
        private System.Windows.Forms.Label lbl_stopNum;
        private System.Windows.Forms.TextBox txt_startNum;
        private System.Windows.Forms.TextBox txt_stopNum;
        private System.Windows.Forms.ListBox listBox1;
    }
}

