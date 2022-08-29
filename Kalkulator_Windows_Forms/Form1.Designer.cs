namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.bWynik = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.bMnozenie = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWynik
            // 
            this.tbWynik.Location = new System.Drawing.Point(21, 12);
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.Size = new System.Drawing.Size(154, 27);
            this.tbWynik.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(21, 57);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(34, 29);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bWynik
            // 
            this.bWynik.Location = new System.Drawing.Point(61, 162);
            this.bWynik.Name = "bWynik";
            this.bWynik.Size = new System.Drawing.Size(74, 29);
            this.bWynik.TabIndex = 2;
            this.bWynik.Text = "=";
            this.bWynik.UseVisualStyleBackColor = true;
            this.bWynik.Click += new System.EventHandler(this.bWynik_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(101, 57);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(34, 29);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(61, 57);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(34, 29);
            this.b2.TabIndex = 4;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(61, 127);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(34, 29);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(21, 127);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(34, 29);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(101, 92);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(34, 29);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(61, 92);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(34, 29);
            this.b5.TabIndex = 8;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(21, 92);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(34, 29);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(21, 162);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(34, 29);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(101, 127);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(34, 29);
            this.b9.TabIndex = 11;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bDodawanie
            // 
            this.bDodawanie.Location = new System.Drawing.Point(141, 57);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(34, 29);
            this.bDodawanie.TabIndex = 12;
            this.bDodawanie.Text = "+";
            this.bDodawanie.UseVisualStyleBackColor = true;
            this.bDodawanie.Click += new System.EventHandler(this.bDodawanie_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.Location = new System.Drawing.Point(141, 162);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(34, 29);
            this.bDzielenie.TabIndex = 15;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = true;
            this.bDzielenie.Click += new System.EventHandler(this.bDzielenie_Click);
            // 
            // bMnozenie
            // 
            this.bMnozenie.Location = new System.Drawing.Point(141, 127);
            this.bMnozenie.Name = "bMnozenie";
            this.bMnozenie.Size = new System.Drawing.Size(34, 29);
            this.bMnozenie.TabIndex = 14;
            this.bMnozenie.Text = "*";
            this.bMnozenie.UseVisualStyleBackColor = true;
            this.bMnozenie.Click += new System.EventHandler(this.bMnozenie_Click);
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.Location = new System.Drawing.Point(141, 92);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(34, 29);
            this.bOdejmowanie.TabIndex = 13;
            this.bOdejmowanie.Text = "-";
            this.bOdejmowanie.UseVisualStyleBackColor = true;
            this.bOdejmowanie.Click += new System.EventHandler(this.bOdejmowanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 229);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.bMnozenie);
            this.Controls.Add(this.bOdejmowanie);
            this.Controls.Add(this.bDodawanie);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.bWynik);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tbWynik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbWynik;
        private Button b1;
        private Button bWynik;
        private Button b3;
        private Button b2;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b0;
        private Button b9;
        private Button bDodawanie;
        private Button bDzielenie;
        private Button bMnozenie;
        private Button bOdejmowanie;
    }
}