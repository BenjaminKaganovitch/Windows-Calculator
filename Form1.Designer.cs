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
            labelCurrentOperation = new Label();
            Answere = new TextBox();
            button15 = new Button();
            button10 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
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
            button1.Click += NumButton;
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
            button2.Click += NumButton;
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
            button3.Click += NumButton;
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
            button4.Click += NumButton;
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
            button5.Click += NumButton;
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
            button6.Click += NumButton;
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
            button7.Click += NumButton;
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
            button8.Click += NumButton;
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
            button9.Click += NumButton;
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
            button17.Click += NumButton;
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
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Location = new Point(159, 23);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 20);
            labelCurrentOperation.TabIndex = 22;
            labelCurrentOperation.Click += label1_Click_1;
            // 
            // Answere
            // 
            Answere.Location = new Point(167, 60);
            Answere.Name = "Answere";
            Answere.Size = new Size(125, 27);
            Answere.TabIndex = 23;
            Answere.Text = "0";
            Answere.TextChanged += Answere_TextChanged;
            // 
            // button15
            // 
            button15.BackColor = Color.SeaGreen;
            button15.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(555, 322);
            button15.Name = "button15";
            button15.Size = new Size(92, 70);
            button15.TabIndex = 24;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = false;
            button15.Click += NumButton;
            // 
            // button10
            // 
            button10.BackColor = Color.SeaGreen;
            button10.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(457, 94);
            button10.Name = "button10";
            button10.Size = new Size(92, 70);
            button10.TabIndex = 26;
            button10.Text = "=";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.SeaGreen;
            button19.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button19.Location = new Point(555, 94);
            button19.Name = "button19";
            button19.Size = new Size(92, 70);
            button19.TabIndex = 27;
            button19.Text = "BIN";
            button19.UseVisualStyleBackColor = false;
            button19.Click += ModeConvert;
            // 
            // button20
            // 
            button20.BackColor = Color.SeaGreen;
            button20.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button20.Location = new Point(555, 170);
            button20.Name = "button20";
            button20.Size = new Size(92, 70);
            button20.TabIndex = 28;
            button20.Text = "DEC";
            button20.UseVisualStyleBackColor = false;
            button20.Click += ModeConvert;
            // 
            // button21
            // 
            button21.BackColor = Color.SeaGreen;
            button21.Font = new Font("TI-Nspire Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button21.Location = new Point(554, 246);
            button21.Name = "button21";
            button21.Size = new Size(92, 70);
            button21.TabIndex = 29;
            button21.Text = "LOC";
            button21.UseVisualStyleBackColor = false;
            button21.Click += ModeConvert;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button10);
            Controls.Add(button15);
            Controls.Add(Answere);
            Controls.Add(labelCurrentOperation);
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
        private Label labelCurrentOperation;
        private TextBox Answere;
        private Button button15;
        private Button button10;
        private Button button19;
        private Button button20;
        private Button button21;
    }
}