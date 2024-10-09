namespace Rezystory
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
            color_1 = new ComboBox();
            pictureBox1 = new PictureBox();
            color_2 = new ComboBox();
            pictureBox2 = new PictureBox();
            color_3 = new ComboBox();
            pictureBox3 = new PictureBox();
            color_4 = new ComboBox();
            pictureBox4 = new PictureBox();
            color_1_txt = new Label();
            color_2_txt = new Label();
            color_3_txt = new Label();
            color_4_txt = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            resistance = new TextBox();
            calculation = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // color_1
            // 
            color_1.DropDownStyle = ComboBoxStyle.DropDownList;
            color_1.FormattingEnabled = true;
            color_1.ImeMode = ImeMode.NoControl;
            color_1.Items.AddRange(new object[] { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Gray", "White" });
            color_1.Location = new Point(138, 75);
            color_1.Name = "color_1";
            color_1.Size = new Size(182, 33);
            color_1.TabIndex = 0;
            color_1.SelectedIndexChanged += color_1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(346, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 33);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // color_2
            // 
            color_2.DropDownStyle = ComboBoxStyle.DropDownList;
            color_2.FormattingEnabled = true;
            color_2.Items.AddRange(new object[] { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Gray", "White" });
            color_2.Location = new Point(138, 141);
            color_2.Name = "color_2";
            color_2.Size = new Size(182, 33);
            color_2.TabIndex = 2;
            color_2.SelectedIndexChanged += color_2_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(346, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 33);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // color_3
            // 
            color_3.DropDownStyle = ComboBoxStyle.DropDownList;
            color_3.FormattingEnabled = true;
            color_3.Items.AddRange(new object[] { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Gold", "Silver" });
            color_3.Location = new Point(138, 207);
            color_3.Name = "color_3";
            color_3.Size = new Size(182, 33);
            color_3.TabIndex = 4;
            color_3.SelectedIndexChanged += color_3_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(346, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 33);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // color_4
            // 
            color_4.DropDownStyle = ComboBoxStyle.DropDownList;
            color_4.FormattingEnabled = true;
            color_4.Items.AddRange(new object[] { "Brown", "Red", "Green", "Blue", "Indigo", "Gray", "Gold", "Silver", "No color" });
            color_4.Location = new Point(138, 273);
            color_4.Name = "color_4";
            color_4.Size = new Size(182, 33);
            color_4.TabIndex = 6;
            color_4.SelectedIndexChanged += color_4_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(346, 273);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 33);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // color_1_txt
            // 
            color_1_txt.AutoSize = true;
            color_1_txt.Location = new Point(61, 78);
            color_1_txt.Name = "color_1_txt";
            color_1_txt.Size = new Size(63, 25);
            color_1_txt.TabIndex = 8;
            color_1_txt.Text = "Strip 1";
            // 
            // color_2_txt
            // 
            color_2_txt.AutoSize = true;
            color_2_txt.Location = new Point(61, 144);
            color_2_txt.Name = "color_2_txt";
            color_2_txt.Size = new Size(63, 25);
            color_2_txt.TabIndex = 9;
            color_2_txt.Text = "Strip 2";
            // 
            // color_3_txt
            // 
            color_3_txt.AutoSize = true;
            color_3_txt.Location = new Point(61, 210);
            color_3_txt.Name = "color_3_txt";
            color_3_txt.Size = new Size(63, 25);
            color_3_txt.TabIndex = 10;
            color_3_txt.Text = "Strip 3";
            // 
            // color_4_txt
            // 
            color_4_txt.AutoSize = true;
            color_4_txt.Location = new Point(61, 276);
            color_4_txt.Name = "color_4_txt";
            color_4_txt.Size = new Size(63, 25);
            color_4_txt.TabIndex = 11;
            color_4_txt.Text = "Strip 4";
            // 
            // resistance
            // 
            resistance.Location = new Point(280, 374);
            resistance.Name = "resistance";
            resistance.ReadOnly = true;
            resistance.Size = new Size(150, 31);
            resistance.TabIndex = 12;
            resistance.TextAlign = HorizontalAlignment.Center;
            // 
            // calculation
            // 
            calculation.Location = new Point(61, 371);
            calculation.Name = "calculation";
            calculation.Size = new Size(182, 34);
            calculation.TabIndex = 13;
            calculation.Text = "Calculate";
            calculation.UseVisualStyleBackColor = true;
            calculation.Click += calculation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 346);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 14;
            label1.Text = "Resistor value:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(519, 439);
            Controls.Add(label1);
            Controls.Add(calculation);
            Controls.Add(resistance);
            Controls.Add(color_4_txt);
            Controls.Add(color_3_txt);
            Controls.Add(color_2_txt);
            Controls.Add(color_1_txt);
            Controls.Add(pictureBox4);
            Controls.Add(color_4);
            Controls.Add(pictureBox3);
            Controls.Add(color_3);
            Controls.Add(pictureBox2);
            Controls.Add(color_2);
            Controls.Add(pictureBox1);
            Controls.Add(color_1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resistance Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox color_1;
        private PictureBox pictureBox1;
        private ComboBox color_2;
        private PictureBox pictureBox2;
        private ComboBox color_3;
        private PictureBox pictureBox3;
        private ComboBox color_4;
        private PictureBox pictureBox4;
        private Label color_1_txt;
        private Label color_2_txt;
        private Label color_3_txt;
        private Label color_4_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox resistance;
        private Button calculation;
        private Label label1;
    }
}