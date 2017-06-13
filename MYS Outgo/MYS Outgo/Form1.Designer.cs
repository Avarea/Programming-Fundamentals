namespace MYS_Outgo
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
            this.slCompletes = new System.Windows.Forms.TextBox();
            this.flCompletes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.slIR = new System.Windows.Forms.TextBox();
            this.flIR = new System.Windows.Forms.TextBox();
            this.slDOR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flDOR = new System.Windows.Forms.TextBox();
            this.slRR = new System.Windows.Forms.TextBox();
            this.flRR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.slSample = new System.Windows.Forms.TextBox();
            this.flSample = new System.Windows.Forms.TextBox();
            this.totalSample = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // slCompletes
            // 
            this.slCompletes.Location = new System.Drawing.Point(120, 98);
            this.slCompletes.Name = "slCompletes";
            this.slCompletes.Size = new System.Drawing.Size(100, 20);
            this.slCompletes.TabIndex = 0;
            this.slCompletes.Text = "0";
            this.slCompletes.TextChanged += new System.EventHandler(this.slCompletes_TextChanged);
            // 
            // flCompletes
            // 
            this.flCompletes.Location = new System.Drawing.Point(305, 98);
            this.flCompletes.Name = "flCompletes";
            this.flCompletes.Size = new System.Drawing.Size(100, 20);
            this.flCompletes.TabIndex = 4;
            this.flCompletes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soft Launch";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full Launch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(166, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Sample Needed";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // slIR
            // 
            this.slIR.Location = new System.Drawing.Point(120, 124);
            this.slIR.Name = "slIR";
            this.slIR.Size = new System.Drawing.Size(100, 20);
            this.slIR.TabIndex = 10;
            this.slIR.Text = "0";
            // 
            // flIR
            // 
            this.flIR.Location = new System.Drawing.Point(305, 124);
            this.flIR.Name = "flIR";
            this.flIR.Size = new System.Drawing.Size(100, 20);
            this.flIR.TabIndex = 11;
            this.flIR.Text = "0";
            // 
            // slDOR
            // 
            this.slDOR.Location = new System.Drawing.Point(120, 150);
            this.slDOR.Name = "slDOR";
            this.slDOR.Size = new System.Drawing.Size(100, 20);
            this.slDOR.TabIndex = 12;
            this.slDOR.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "# of Completes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Incidence Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dropout Rate";
            // 
            // flDOR
            // 
            this.flDOR.Location = new System.Drawing.Point(305, 147);
            this.flDOR.Name = "flDOR";
            this.flDOR.Size = new System.Drawing.Size(100, 20);
            this.flDOR.TabIndex = 21;
            this.flDOR.Text = "0";
            // 
            // slRR
            // 
            this.slRR.Location = new System.Drawing.Point(120, 176);
            this.slRR.Name = "slRR";
            this.slRR.Size = new System.Drawing.Size(100, 20);
            this.slRR.TabIndex = 23;
            this.slRR.Text = "0";
            // 
            // flRR
            // 
            this.flRR.Location = new System.Drawing.Point(305, 173);
            this.flRR.Name = "flRR";
            this.flRR.Size = new System.Drawing.Size(100, 20);
            this.flRR.TabIndex = 24;
            this.flRR.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Response Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sample Needed";
            // 
            // slSample
            // 
            this.slSample.Location = new System.Drawing.Point(120, 243);
            this.slSample.Name = "slSample";
            this.slSample.Size = new System.Drawing.Size(100, 20);
            this.slSample.TabIndex = 28;
            // 
            // flSample
            // 
            this.flSample.Location = new System.Drawing.Point(305, 243);
            this.flSample.Name = "flSample";
            this.flSample.Size = new System.Drawing.Size(100, 20);
            this.flSample.TabIndex = 29;
            // 
            // totalSample
            // 
            this.totalSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.totalSample.ForeColor = System.Drawing.Color.Red;
            this.totalSample.Location = new System.Drawing.Point(195, 314);
            this.totalSample.Multiline = true;
            this.totalSample.Name = "totalSample";
            this.totalSample.Size = new System.Drawing.Size(107, 40);
            this.totalSample.TabIndex = 30;
            this.totalSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(120, 202);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(285, 23);
            this.calculate.TabIndex = 31;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Boyata Rulz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 414);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.totalSample);
            this.Controls.Add(this.flSample);
            this.Controls.Add(this.slSample);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flRR);
            this.Controls.Add(this.slRR);
            this.Controls.Add(this.flDOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.slDOR);
            this.Controls.Add(this.flIR);
            this.Controls.Add(this.slIR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flCompletes);
            this.Controls.Add(this.slCompletes);
            this.Name = "Form1";
            this.Text = "MYS Outgo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slCompletes;
        private System.Windows.Forms.TextBox flCompletes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox slIR;
        private System.Windows.Forms.TextBox flIR;
        private System.Windows.Forms.TextBox slDOR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox flDOR;
        private System.Windows.Forms.TextBox slRR;
        private System.Windows.Forms.TextBox flRR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox slSample;
        private System.Windows.Forms.TextBox flSample;
        private System.Windows.Forms.TextBox totalSample;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label9;
    }
}

