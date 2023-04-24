using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CalculatorVerstion2
{
    public partial class Form1 : Form
    {
        // This will be used to keep track of what mode the program is in, such as "DEC", "BIN", "LOC", etc:
        String mode = "DEC";

        // Result Value Varaiables
        Double resultValue = 0;

        // Operation Performed Varaiables
        String operationPerformed = "";
        bool isOperationUsed = false;

        public Form1()
        {
            InitializeComponent();
        }



        // This will handle all the number buttons
        private void NumButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((Answere.Text == "0") || (isOperationUsed) || Answere.Text == "Error")
                Answere.Clear();
            isOperationUsed = false;

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



        // The following code is for the operation buttons: +, -, *, /
        private void PerformOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // If there is a previous result, perform the operation and display it
            if (resultValue != 0)
            {
                // simulate a click on the equals button to perform the previous operation
                button10.PerformClick(); 
                operationPerformed = button.Text;
                labelOperatorUsed.Text = resultValue + " " + operationPerformed; 
                isOperationUsed = true;
            }
            // If there is no previous result, store the current value and operation
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(Answere.Text);
                labelOperatorUsed.Text = resultValue + " " + operationPerformed; 
                isOperationUsed = true;
            }

            // Store the current value and operation and update the label to show the current operation
            operationPerformed = button.Text;
            resultValue = Double.Parse(Answere.Text);
            labelOperatorUsed.Text = resultValue + " " + operationPerformed;
            isOperationUsed = true;
        }



        // Clear button
        private void button18_Click(object sender, EventArgs e)
        {
            Answere.Text = "0";
            mode = "DEC";
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
            labelOperatorUsed.Text = "";
        }



        // this method will handle you switching to different modes, such as 'bin" or "loc", etc:
        // Im assuming this satisfys the bonus requirement of having tabs for different modes, as they perform converstions between modes as you switch from one to another
        private void ModeConvert(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "BIN")
            {
                // Convert the current answer to binary
                int decValue = int.Parse(Answere.Text);
                Answere.Text = Convert.ToString(decValue, 2);
                mode = "BIN";
            }
            else if (button.Text == "DEC")
            {
                // Convert the current answer to decimal (if it's currently in binary)
                if (mode == "BIN")
                {
                    int binValue = Convert.ToInt32(Answere.Text, 2);
                    Answere.Text = binValue.ToString();
                }
                // Cannot convert from location numeral to decimal
                else if (mode == "LOC")
                {
                    Answere.Text = "Error";
                    return;
                }
                mode = "DEC";
            }
            else if (button.Text == "LOC")
            {
                // Convert the current answer to a location numeral (if it's currently in decimal)
                if (mode == "DEC")
                {
                    decimal decimalValue = decimal.Parse(Answere.Text);
                    string locationNumeral = "";

                    // Convert integer part to location numeral
                    int integerPart = (int)Math.Truncate(decimalValue);
                    while (integerPart > 0)
                    {
                        int remainder = integerPart % 27;
                        if (remainder == 0)
                        {
                            locationNumeral = " " + locationNumeral;
                        }
                        else
                        {
                            char character = (char)(remainder + 96);
                            locationNumeral = character + locationNumeral;
                        }
                        integerPart = (integerPart - remainder) / 27;
                    }

                    // Convert fractional part to location numeral
                    decimal fractionalPart = decimalValue - Math.Truncate(decimalValue);
                    if (fractionalPart > 0)
                    {
                        locationNumeral += ".";
                        for (int i = 0; i < 5; i++)
                        {
                            fractionalPart *= 27;
                            int digit = (int)Math.Truncate(fractionalPart);
                            char character = (char)(digit + 96);
                            locationNumeral += character;
                            fractionalPart -= digit;
                        }
                    }

                    Answere.Text = locationNumeral;
                    mode = "LOC";
                }

                else
                {
                    Answere.Text = "Error";
                    return;
                }
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Answere text box
        private void Answere_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
