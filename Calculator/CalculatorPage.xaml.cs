using System.Diagnostics;
using Xamarin.Forms;

namespace Calculator
{
    public partial class CalculatorPage : ContentPage
    {
        public string data = "";

        public CalculatorPage()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(CalculatorPage)}:  constructor");
            InitializeComponent();
        }

        void Handle_0(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "0";
            data = EquationBar.Text;
        }

        void Handle_1(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "1";
            data = EquationBar.Text;
        }

        void Handle_2(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "2";
            data = EquationBar.Text;
        }

        void Handle_3(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "3";
            data = EquationBar.Text;
        }

        void Handle_4(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "4";
            data = EquationBar.Text;
        }

        void Handle_5(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "5";
            data = EquationBar.Text;
        }

        void Handle_6(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "6";
            data = EquationBar.Text;
        }

        void Handle_7(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "7";
            data = EquationBar.Text;
        }

        void Handle_8(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "8";
            data = EquationBar.Text;
        }

        void Handle_9(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "9";
            data = EquationBar.Text;
        }

        void Handle_Add(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "+";
            data = EquationBar.Text;
        }

        void Handle_Multiply(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "X";
            data = EquationBar.Text;
        }

        void Handle_Subtract(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "-";
            data = EquationBar.Text;
        }
        void Handle_Divide(object sender, System.EventArgs e)
        {
            EquationBar.Text = EquationBar.Text + "/";
            data = EquationBar.Text;
        }

        void Handle_Clear(object sender, System.EventArgs e)
        {
            EquationBar.Text = "";
            data = "";
        }

        void Handle_Equal(object sender, System.EventArgs e)
        {
            if (data == "")
            { EquationBar.Text = "Error"; }
            else
            {
                string first = "", second = "";
                char operation = ' ';
                int size = data.Length;
                if (data[size - 1] == '+' || data[0] == '+' || data[size - 1] == '-' || data[0] == '-' || data[size - 1] == '/' || data[0] == '/' || data[size - 1] == 'X' || data[0] == 'X')
                {
                    EquationBar.Text = "Error";
                }
                else
                {
                    
                    //reading the string to separate chars
                    int totNum = 1;
                    for (int i = 0; i < size; i++)
                    {
                        

                        if (data[i] == '+' || data[i] == '-' || data[i] == '/' || data[i] == 'X')
                        {
                           
                            operation = data[i];
                            totNum++;
                        }
                        else if (data[i] != '+' || data[i] != '-' || data[i] != 'X' || data[i] != '/')
                        {
                            
                            if (totNum == 1) { first = first + data[i]; }
                            if (totNum == 2) { second = second + data[i]; }

                        }

                    }

                    //working on the operation
                    if (operation == '+')
                    {
                        EquationBar.Text = $"{System.Convert.ToInt32(first) + System.Convert.ToInt32(second)}";

                    }

                    if (operation == '-')
                    {
                        EquationBar.Text = $"{System.Convert.ToInt32(first) - System.Convert.ToInt32(second)}";

                    }

                    if (operation == '/')
                    {
                        if (second == "0")
                        {
                            EquationBar.Text = "Error: / 0";
                            data = "";
                        }
                        else
                        {
                            EquationBar.Text = $"{System.Convert.ToInt32(first) / System.Convert.ToInt32(second)}";
                        }
                    }

                    if (operation == 'X')
                    {
                        EquationBar.Text = $"{System.Convert.ToInt32(first) * System.Convert.ToInt32(second)}";

                    }
                } //end of else checking operands
            }  // end of else checking data = error
        }  //end of handle_equal
    } //end of class
} //end of calculator
