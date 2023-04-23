namespace CalculatorVerstion2
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

        //a: what do I do to make the button interact with the textbox? 
        //a: You need to add a click event to the button and then add the value of the button to the textbox
        //a: dont I already have that?
        //a: No, you have a click event for the button but you need to add the value of the button to the textbox
        //a: can we do that here?
        //a: No, you need to do that in the designer
        //a: where do I navigate to? 
        //a: You need to double click on the button and it will take you to the designer

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button17 = new Button();
            button18 = new Button();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            labelCurrentOperation = new Label();
            Answere = new TextBox();
            button15 = new Button();
            button16 = new Button();
            button10 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(163, 94);
            button1.Name = "button1";
            button1.Size = new Size(92, 70);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(261, 94);
            button2.Name = "button2";
            button2.Size = new Size(92, 70);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(359, 94);
            button3.Name = "button3";
            button3.Size = new Size(92, 70);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(163, 170);
            button4.Name = "button4";
            button4.Size = new Size(92, 70);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(261, 170);
            button5.Name = "button5";
            button5.Size = new Size(92, 70);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.SeaGreen;
            button6.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(359, 170);
            button6.Name = "button6";
            button6.Size = new Size(92, 70);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.SeaGreen;
            button7.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(163, 246);
            button7.Name = "button7";
            button7.Size = new Size(92, 70);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.SeaGreen;
            button8.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(261, 246);
            button8.Name = "button8";
            button8.Size = new Size(92, 70);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.SeaGreen;
            button9.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(359, 246);
            button9.Name = "button9";
            button9.Size = new Size(92, 70);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.SeaGreen;
            button11.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(457, 170);
            button11.Name = "button11";
            button11.Size = new Size(92, 70);
            button11.TabIndex = 10;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = false;
            button11.Click += PerformOperation;
            // 
            // button12
            // 
            button12.BackColor = Color.SeaGreen;
            button12.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(457, 246);
            button12.Name = "button12";
            button12.Size = new Size(92, 70);
            button12.TabIndex = 11;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += PerformOperation;
            // 
            // button13
            // 
            button13.BackColor = Color.SeaGreen;
            button13.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(163, 322);
            button13.Name = "button13";
            button13.Size = new Size(92, 70);
            button13.TabIndex = 12;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = false;
            button13.Click += PerformOperation;
            // 
            // button14
            // 
            button14.BackColor = Color.SeaGreen;
            button14.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(261, 322);
            button14.Name = "button14";
            button14.Size = new Size(92, 70);
            button14.TabIndex = 13;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = false;
            button14.Click += PerformOperation;
            // 
            // button17
            // 
            button17.BackColor = Color.SeaGreen;
            button17.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(359, 322);
            button17.Name = "button17";
            button17.Size = new Size(92, 70);
            button17.TabIndex = 16;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.SeaGreen;
            button18.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(457, 322);
            button18.Name = "button18";
            button18.Size = new Size(92, 70);
            button18.TabIndex = 17;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(576, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            radioButton3.AutoCheck = false;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 87);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "LOC";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoCheck = false;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "BIN";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoCheck = false;
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "DEC";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Location = new Point(159, 23);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(157, 20);
            labelCurrentOperation.TabIndex = 22;
            labelCurrentOperation.Text = "labelCurrentOperation";
            labelCurrentOperation.Click += label1_Click_1;
            // 
            // Answere
            // 
            Answere.Location = new Point(167, 60);
            Answere.Name = "Answere";
            Answere.Size = new Size(125, 27);
            Answere.TabIndex = 23;
            Answere.TextChanged += Answere_TextChanged;
            // 
            // button15
            // 
            button15.BackColor = Color.SeaGreen;
            button15.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(65, 246);
            button15.Name = "button15";
            button15.Size = new Size(92, 70);
            button15.TabIndex = 24;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click_1;
            // 
            // button16
            // 
            button16.BackColor = Color.SeaGreen;
            button16.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(554, 322);
            button16.Name = "button16";
            button16.Size = new Size(92, 70);
            button16.TabIndex = 25;
            button16.Text = "CE";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.SeaGreen;
            button10.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(457, 97);
            button10.Name = "button10";
            button10.Size = new Size(92, 70);
            button10.TabIndex = 26;
            button10.Text = "=";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button10);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(Answere);
            Controls.Add(labelCurrentOperation);
            Controls.Add(groupBox1);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button17;
        private Button button18;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label labelCurrentOperation;
        private TextBox Answere;
        private Button button15;
        private Button button16;
        private Button button10;
    }
}