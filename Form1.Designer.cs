namespace Practice
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ctrlCalculateNumbers1 = new Practice.ctrlCalculateNumbers();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(396, 362);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(229, 60);
            this.btnGetData.TabIndex = 3;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 254);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 43);
            this.textBox1.TabIndex = 2;
            // 
            // ctrlCalculateNumbers1
            // 
            this.ctrlCalculateNumbers1.BackColor = System.Drawing.Color.Gray;
            this.ctrlCalculateNumbers1.Location = new System.Drawing.Point(60, 26);
            this.ctrlCalculateNumbers1.Name = "ctrlCalculateNumbers1";
            this.ctrlCalculateNumbers1.Size = new System.Drawing.Size(675, 164);
            this.ctrlCalculateNumbers1.TabIndex = 4;
            this.ctrlCalculateNumbers1.OnCalclulationSelected += new System.EventHandler<Practice.ctrlCalculateNumbers.CalculationCompletedEventArgs>(this.ctrlCalculateNumbers1_OnCalclulationSelected);
            this.ctrlCalculateNumbers1.Load += new System.EventHandler(this.ctrlCalculateNumbers1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCalculateNumbers1);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox textBox1;
        private ctrlCalculateNumbers ctrlCalculateNumbers1;
    }
}

