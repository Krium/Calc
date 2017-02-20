using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBLOCK_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _operation=string.Empty;
        string _operand1 = string.Empty;
        string _operand2 = string.Empty;
        string input=string.Empty;
        double _memory = 0.0;
        double _rezult = 0.0;

        bool tmp1=false;

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            _operation = "+";
            _operand1 = input;
            input = string.Empty;
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;
                TxtB.Text = String.Concat(tmp + "+") ;
                tmp1 = false;
            }
            else
            {
                TxtB.Text = "+";
                tmp1 = false;
            }
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            _operand2 = input;
            double value1, value2;
            double.TryParse(_operand1, out value1);
            double.TryParse(_operand2, out value2);
                    switch (_operation)
                    {
                        case "+":
                            _rezult = value1 + value2;
                            TxtB.Text=_rezult.ToString();
                            _rezult = 0.0;
                            break;
                        case "-":
                           _rezult = value1 - value2;
                            TxtB.Text=_rezult.ToString();
                            _rezult = 0.0;
                            break;
                        case "*":
                           _rezult = value1 * value2;
                            TxtB.Text=_rezult.ToString();
                            _rezult = 0.0;
                            break;
                        case "/":
                            if (value2 != 0)
                            {
                                _rezult = value1 / value2;
                                TxtB.Text = _rezult.ToString();
                                _rezult = 0.0;
                                break;
                            }
                            else
                            {
                                TxtB.Text = "Nemowna dilyty na nul";
                                break;
                            }
                    }
                    tmp1 = true;
                    input = TxtB.Text;
                
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }

            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "1");
                input += "1";
                tmp1 = false;
            }
            else
            {
                TxtB.Text = "1";
                input += "1";
                tmp1 = false;
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }
            
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "2");
                input += "2";
            }
            else
            {
                TxtB.Text = "2";
                input += "2";
            }
        }

        private void tree_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }
            
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "3");
                input += "3";
            }
            else
            {
                TxtB.Text = "3";
                input += "3";
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }
            
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "4");
                input += "4";
            }
            else
            {
                TxtB.Text = "4";
                input += "4";
            }
        }

        private void fife_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }
            
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "5");
                input += "5";
            }
            else
            {
                TxtB.Text = "5";
                input += "5";
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }
            
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "6");
                input += "6";
            }
            else
            {
                TxtB.Text = "6";
                input += "6";
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }
            
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "7");
                input += "7";
            }
            else
            {
                TxtB.Text = "7";
                input += "7";
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }

            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "9");
                input += "9";
            }
            else
            {
                TxtB.Text = "9";
                input += "9";
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }

            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "8");
                input += "8";
            }
            else
            {
                TxtB.Text = "8";
                input += "8";
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            _operation = "-";
            _operand1 = input;
            input = string.Empty;
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;
                tmp1 = false;
                TxtB.Text = String.Concat(tmp + "-");               
            }
            else
            {
                TxtB.Text = "-";
                tmp1 = false;
            }
        }

        private void Mnowennya_Click(object sender, RoutedEventArgs e)
        {
            _operation = "*";
            _operand1 = input;
            input = string.Empty;
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "*");
                tmp1 = false;
            }
            else
            {
                TxtB.Text = "*";
                tmp1 = false;
            }
        }

        private void Dilennya_Click(object sender, RoutedEventArgs e)
        {
            _operation = "/";
            _operand1 = input;
            input = string.Empty;
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "/");
                tmp1 = false;
            }
            else
            {
                TxtB.Text = "/";
                tmp1 = false;
            }
        }

        private void coma_Click(object sender, RoutedEventArgs e)
        {
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;
                tmp1 = false;
                TxtB.Text = String.Concat(tmp + ".");
                input += ",";
            }
            else
            {
                TxtB.Text = ".";
                input += ",";
                tmp1 = false;
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            this.TxtB.Text = "";
            this.input = string.Empty;
            this._operand1 = string.Empty;
            this._operand2 = string.Empty;
            tmp1 = false;
        }

        private void MR_Click(object sender, RoutedEventArgs e)
        {
            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;
                tmp1 = false;
                TxtB.Text = String.Concat(tmp + _memory.ToString());

            }
            else
            {
                tmp1 = false;
                TxtB.Text = _memory.ToString();
            }
        }

        private void M__Click(object sender, RoutedEventArgs e)
        {
            if (_memory != 0.0)
            {
                double tmp = _memory;
                _memory = tmp - Convert.ToDouble(TxtB.Text);
            }
            else
            {
                _memory = Convert.ToDouble(TxtB.Text);
            }
        }

        private void Mplus_Click(object sender, RoutedEventArgs e)
        {
            if (_memory != 0.0)
            {
                double tmp = _memory;
                _memory = tmp + Convert.ToDouble(TxtB.Text);
            }
            else
            {
                _memory = Convert.ToDouble(TxtB.Text);
            }
        }

        private void Ms_Click(object sender, RoutedEventArgs e)
        {
            _memory = Convert.ToDouble(TxtB.Text);
        }

        private void MC_Click(object sender, RoutedEventArgs e)
        {
            _memory = 0.0;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 == true)
            {
                TxtB.Text = "";
                input = string.Empty;
            }

            if (TxtB.Text != null)
            {
                string tmp = TxtB.Text;

                TxtB.Text = String.Concat(tmp + "0");
                input += "0";
            }
            else
            {
                TxtB.Text = "0";
                input += "0";
            }
        }
    }
}
