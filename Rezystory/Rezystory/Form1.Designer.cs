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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            color_5 = new ComboBox();
            color_6 = new ComboBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            numberOfStrips = new ComboBox();
            color_5_txt = new Label();
            color_6_txt = new Label();
            label2 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // color_1
            // 
            color_1.DropDownStyle = ComboBoxStyle.DropDownList;
            color_1.FormattingEnabled = true;
            color_1.ImeMode = ImeMode.NoControl;
            color_1.Items.AddRange(new object[] { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Gray", "White" });
            color_1.Location = new Point(223, 105);
            color_1.Name = "color_1";
            color_1.Size = new Size(182, 33);
            color_1.TabIndex = 0;
            color_1.SelectedIndexChanged += color_1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(431, 105);
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
            color_2.Location = new Point(223, 171);
            color_2.Name = "color_2";
            color_2.Size = new Size(182, 33);
            color_2.TabIndex = 2;
            color_2.SelectedIndexChanged += color_2_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(431, 171);
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
            color_3.Location = new Point(657, 105);
            color_3.Name = "color_3";
            color_3.Size = new Size(182, 33);
            color_3.TabIndex = 4;
            color_3.SelectedIndexChanged += color_3_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(865, 105);
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
            color_4.Location = new Point(657, 171);
            color_4.Name = "color_4";
            color_4.Size = new Size(182, 33);
            color_4.TabIndex = 6;
            color_4.SelectedIndexChanged += color_4_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(865, 171);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 33);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // color_1_txt
            // 
            color_1_txt.AutoSize = true;
            color_1_txt.Location = new Point(154, 113);
            color_1_txt.Name = "color_1_txt";
            color_1_txt.Size = new Size(63, 25);
            color_1_txt.TabIndex = 8;
            color_1_txt.Text = "Strip 1";
            // 
            // color_2_txt
            // 
            color_2_txt.AutoSize = true;
            color_2_txt.Location = new Point(154, 179);
            color_2_txt.Name = "color_2_txt";
            color_2_txt.Size = new Size(63, 25);
            color_2_txt.TabIndex = 9;
            color_2_txt.Text = "Strip 2";
            // 
            // color_3_txt
            // 
            color_3_txt.AutoSize = true;
            color_3_txt.Location = new Point(566, 113);
            color_3_txt.Name = "color_3_txt";
            color_3_txt.Size = new Size(86, 25);
            color_3_txt.TabIndex = 10;
            color_3_txt.Text = "Multiplier";
            // 
            // color_4_txt
            // 
            color_4_txt.AutoSize = true;
            color_4_txt.Location = new Point(566, 179);
            color_4_txt.Name = "color_4_txt";
            color_4_txt.Size = new Size(85, 25);
            color_4_txt.TabIndex = 11;
            color_4_txt.Text = "Tolerance";
            // 
            // resistance
            // 
            resistance.Location = new Point(566, 345);
            resistance.Name = "resistance";
            resistance.ReadOnly = true;
            resistance.Size = new Size(251, 31);
            resistance.TabIndex = 12;
            resistance.TextAlign = HorizontalAlignment.Center;
            // 
            // calculation
            // 
            calculation.Location = new Point(347, 342);
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
            label1.Location = new Point(566, 317);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 14;
            label1.Text = "Resistor value:";
            // 
            // color_5
            // 
            color_5.DropDownStyle = ComboBoxStyle.DropDownList;
            color_5.FormattingEnabled = true;
            color_5.Items.AddRange(new object[] { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Gray", "White" });
            color_5.Location = new Point(223, 242);
            color_5.Name = "color_5";
            color_5.Size = new Size(182, 33);
            color_5.TabIndex = 15;
            color_5.Visible = false;
            color_5.SelectedIndexChanged += color_5_SelectedIndexChanged;
            // 
            // color_6
            // 
            color_6.DropDownStyle = ComboBoxStyle.DropDownList;
            color_6.FormattingEnabled = true;
            color_6.Items.AddRange(new object[] { "Brown", "Red", "Orange", "Yellow", "Blue", "Indigo" });
            color_6.Location = new Point(657, 237);
            color_6.Name = "color_6";
            color_6.Size = new Size(182, 33);
            color_6.TabIndex = 16;
            color_6.Visible = false;
            color_6.SelectedIndexChanged += color_6_SelectedIndexChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(431, 242);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(84, 33);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Location = new Point(865, 237);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(84, 33);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // numberOfStrips
            // 
            numberOfStrips.DropDownStyle = ComboBoxStyle.DropDownList;
            numberOfStrips.FormattingEnabled = true;
            numberOfStrips.Items.AddRange(new object[] { 4, 5, 6 });
            numberOfStrips.Location = new Point(117, 39);
            numberOfStrips.Name = "numberOfStrips";
            numberOfStrips.Size = new Size(59, 33);
            numberOfStrips.TabIndex = 19;
            numberOfStrips.SelectedIndexChanged += numberOfStrips_SelectedIndexChanged;
            // 
            // color_5_txt
            // 
            color_5_txt.AutoSize = true;
            color_5_txt.Location = new Point(154, 250);
            color_5_txt.Name = "color_5_txt";
            color_5_txt.Size = new Size(63, 25);
            color_5_txt.TabIndex = 20;
            color_5_txt.Text = "Strip 3";
            color_5_txt.Visible = false;
            // 
            // color_6_txt
            // 
            color_6_txt.AutoSize = true;
            color_6_txt.Location = new Point(603, 245);
            color_6_txt.Name = "color_6_txt";
            color_6_txt.Size = new Size(48, 25);
            color_6_txt.TabIndex = 21;
            color_6_txt.Text = "PPM";
            color_6_txt.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 31);
            label2.Name = "label2";
            label2.Size = new Size(99, 50);
            label2.TabIndex = 22;
            label2.Text = "Number of\r\n     strips";
            // 
            // pictureBox7
            // 
            pictureBox7.ImageLocation = "Images\\resistor6.jpg";
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(1101, 82);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(344, 224);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            pictureBox7.WaitOnLoad = true;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(232, 225, 215);
            pictureBox8.Location = new Point(1127, 84);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(22, 72);
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(232, 225, 215);
            pictureBox9.Location = new Point(1174, 94);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(22, 52);
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(232, 225, 215);
            pictureBox10.Location = new Point(1207, 94);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(22, 52);
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            pictureBox10.Visible = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(232, 225, 215);
            pictureBox11.Location = new Point(1273, 94);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(22, 52);
            pictureBox11.TabIndex = 27;
            pictureBox11.TabStop = false;
            pictureBox11.Visible = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.FromArgb(232, 225, 215);
            pictureBox12.Location = new Point(1326, 94);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(22, 52);
            pictureBox12.TabIndex = 28;
            pictureBox12.TabStop = false;
            pictureBox12.Visible = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.FromArgb(232, 225, 215);
            pictureBox13.Location = new Point(1377, 82);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(22, 72);
            pictureBox13.TabIndex = 29;
            pictureBox13.TabStop = false;
            pictureBox13.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1466, 406);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(label2);
            Controls.Add(color_6_txt);
            Controls.Add(color_5_txt);
            Controls.Add(numberOfStrips);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(color_6);
            Controls.Add(color_5);
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
            Text = "Resistance Calculator v2.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
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
        private ComboBox color_5;
        private ComboBox color_6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ComboBox numberOfStrips;
        private Label color_5_txt;
        private Label color_6_txt;
        private Label label2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
    }
}