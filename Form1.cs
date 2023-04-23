namespace CalculatorVerstion2
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "1";
            isOperationPerformed = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "2";
            isOperationPerformed = false;
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "3";
            isOperationPerformed = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "4";
            isOperationPerformed = false;
            
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "5";
            isOperationPerformed = false;
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "6";
            isOperationPerformed = false;
            
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "7";
            isOperationPerformed = false;
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "8";
            isOperationPerformed = false;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "9";
            isOperationPerformed = false;
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "9";
            isOperationPerformed = false;
            
        }

        // This button is for zero
        private void button15_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Answere.Text = Answere.Text + "0";
            isOperationPerformed = false;
            
        }




        





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // DEC radio button
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // HEX radio button
            radioButton1.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // OCT radio button
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }





        



        /*
         * 
         * The following code is for the operation buttons: +, -, *, /
         */
        private void PerformOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(Answere.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        // CE button
        private void button16_Click(object sender, EventArgs e)
        {
            Answere.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Answere.Text = "0";
            resultValue = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    Answere.Text = (resultValue + Double.Parse(Answere.Text)).ToString();
                    break;
                case "-":
                    Answere.Text = (resultValue - Double.Parse(Answere.Text)).ToString();
                    break;
                case "*":
                    Answere.Text = (resultValue * Double.Parse(Answere.Text)).ToString();
                    break;
                case "/":
                    Answere.Text = (resultValue / Double.Parse(Answere.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {


        }
        private void button11_Click(object sender, EventArgs e)
        {


        }
        private void button12_Click_1(object sender, EventArgs e)
        {


        }
        private void button13_Click_1(object sender, EventArgs e)
        {


        }
        private void button14_Click(object sender, EventArgs e)
        {


        }
        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Answere text box
        private void Answere_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}