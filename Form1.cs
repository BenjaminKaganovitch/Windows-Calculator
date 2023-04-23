namespace CalculatorVerstion2
{
    public partial class Form1 : Form
    {

        // Operation Performed Varaiables
        String operationPerformed = "";
        bool isOperationPerformed = false;

        // Result Value Varaiables
        Double resultValue = 0;


        public Form1()
        {
            InitializeComponent();
        }

        // This will handle all the number buttons
        private void NumButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((Answere.Text == "0") || (isOperationPerformed))
                Answere.Clear();
            isOperationPerformed = false;

            // This code will check if the text box has a decimal point , if it does not it will not add another one.
            // If it does have a decimal point it will add the number to the text box.
            if (button.Text == ".")
            {
                if (!Answere.Text.Contains("."))
                    Answere.Text = Answere.Text + button.Text;

            }
            else
                Answere.Text = Answere.Text + button.Text;
        }

        // This is for the radio buttons to switch between modes
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // DEC radio button
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // BIN radio button
            radioButton1.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // LOC radio button
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        // The following code is for the operation buttons: +, -, *, /
        private void PerformOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // If there is a previous result, perform the operation and display it
            if (resultValue != 0)
            {
                button10.PerformClick(); // simulate a click on the equals button to perform the previous operation
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed; // update the label to show the current operation
                isOperationPerformed = true;
            }
            // If there is no previous result, store the current value and operation
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(Answere.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed; // update the label to show the current operation
                isOperationPerformed = true;
            }

            // Store the current value and operation and update the label to show the current operation
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

        // C button
        private void button18_Click(object sender, EventArgs e)
        {
            Answere.Text = "0";
            resultValue = 0;
        }


        // = button
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
            resultValue = Double.Parse(Answere.Text);
            labelCurrentOperation.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Answere text box
        private void Answere_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModeConvert(object sender, EventArgs e)
        {

        }
    }
}