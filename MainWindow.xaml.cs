using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace HelloWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string input = string.Empty;
		string operand1 = string.Empty;
		string operand2 = string.Empty;
		char operation;
		double result = 0.0;
		Boolean radPressed = false, degPressed = false;

		public MainWindow()
		{
			InitializeComponent();
			//ImageBrush myBrush = new ImageBrush();
			//myBrush.ImageSource =
			//new BitmapImage(new Uri("pack://application:,,,/rainbow.jpg", UriKind.Absolute));
			//this.Background = myBrush;
			
		}

		private void zero_Click(object sender, RoutedEventArgs e)
		{
			// button for number 0
			this.textBox.Text = "";
			input += "0";
			this.textBox.Text += input;
		}

		private void one_Click(object sender, RoutedEventArgs e)
		{
			// button for number 1
			this.textBox.Text = "";
			input += "1";
			this.textBox.Text += input;
		}
		
		private void two_Click(object sender, RoutedEventArgs e)
		{
			// button for number 2
			this.textBox.Text = "";
			input += "2";
			this.textBox.Text += input;
		}

		private void three_Click(object sender, RoutedEventArgs e)
		{
			// button for number 3
			this.textBox.Text = "";
			input += "3";
			this.textBox.Text += input;
		}


		private void four_Click(object sender, RoutedEventArgs e)
		{
			// button for number 4
			this.textBox.Text = "";
			input += "4";
			this.textBox.Text += input;
		}

		private void five_Click(object sender, RoutedEventArgs e)
		{
			// button for number 5
			this.textBox.Text = "";
			input += "5";
			this.textBox.Text += input;
		}

		private void six_Click(object sender, RoutedEventArgs e)
		{
			// button for number 6
			this.textBox.Text = "";
			input += "6";
			this.textBox.Text += input;
		}

		private void seven_Click(object sender, RoutedEventArgs e)
		{
			// button for number 7
			this.textBox.Text = "";
			input += "7";
			this.textBox.Text += input;
		}


		private void eight_Click(object sender, RoutedEventArgs e)
		{
			// button for number 8
			this.textBox.Text = "";
			input += "8";
			this.textBox.Text += input;
		}


		private void nine_Click(object sender, RoutedEventArgs e)
		{
			// button for number 9
			this.textBox.Text = "";
			input += "9";
			this.textBox.Text += input;
		}



		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			// label textbox

		}

		
		private void equals_Click(object sender, RoutedEventArgs e)
		{
            // equals 
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

			if (operation == '+')
			{
				result = num1 + num2;
				textBox.Text = result.ToString();
			}
			else if (operation == '-')
			{
				result = num1 - num2;
				textBox.Text = result.ToString();
			}
			else if (operation == '*')
			{
				result = num1 * num2;
				textBox.Text = result.ToString();
			}
			else if (operation == '/')
			{
				if (num2 != 0)
				{
					result = num1 / num2;
					textBox.Text = result.ToString();
				}
				else
				{
					textBox.Text = "Cannot Divide By 0";
				}
			}
			


		}

		private void multiply_Click(object sender, RoutedEventArgs e)
		{
			// multiply
			textBox.Text = "";
			operand1 = input;
			operation = '*';
			input = string.Empty;
		}

		private void divide_Click(object sender, RoutedEventArgs e)
		{
			// divide
			textBox.Text = "";
			operand1 = input;
			operation = '/';
			input = string.Empty;
		}

		private void subtract_Click(object sender, RoutedEventArgs e)
		{
			// subtract
			textBox.Text = "";
			operand1 = input;
			operation = '-';
			input = string.Empty;
		}

        private void add_Click(object sender, RoutedEventArgs e)
        {
			// add
			textBox.Text = "";
			operand1 = input;
			operation = '+';
			input = string.Empty;
		}


        private void clear_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

		private void dot_Click(object sender, RoutedEventArgs e)
		{
			this.textBox.Text = "";
			input += ".";
			this.textBox.Text += input;
		}

		private void posOrneg_Click(object sender, RoutedEventArgs e)
		{
			if (textBox.Text.StartsWith("-"))
			{
				//It's negative now, so strip the `-` sign to make it positive

				this.textBox.Text = "";
				input += this.textBox.Text = textBox.Text.Substring(1);
				this.textBox.Text += input;
			}
			else if (!string.IsNullOrEmpty(textBox.Text) && decimal.Parse(textBox.Text) != 0)
			{
				//It's positive now, so prefix the value with the `-` sign to make it negative
				
				this.textBox.Text = "-" + textBox.Text;
				input = textBox.Text;
			}

		}

		private void squareroot_Click(object sender, RoutedEventArgs e)
		{
			double number;
			var isDouble = double.TryParse(this.textBox.Text, out number);
			if (isDouble)
			{
				this.textBox.Text =
					string.Format(
						"{2}",
						"\u221A",
						this.textBox.Text,
						Math.Round(Math.Sqrt(number), 2));
			}
		}

		private void pi_Click(object sender, RoutedEventArgs e)
		{
			// button for number 0
			this.textBox.Text = "";
			input += (Math.PI);
			this.textBox.Text += input;
		}

		private void sin_Click(object sender, RoutedEventArgs e)
		{
            if (radPressed == true)
            {
                textBox.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox.Text)));
            }
            else if (degPressed == true)
            {
                textBox.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) *
                    (Convert.ToDouble(textBox.Text))));
            }
        }

		private void cos_Click(object sender, RoutedEventArgs e)
		{
            if (radPressed == true)
            {
                textBox.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox.Text)));
            }
            else if (degPressed == true)
            {
                textBox.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) *
                    (Convert.ToDouble(textBox.Text))));
            }
        }

		private void tan_Click(object sender, RoutedEventArgs e)
		{
			if (radPressed == true)
			{
				textBox.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox.Text)));
			}
			else if (degPressed == true)
			{
                textBox.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * 
                    (Convert.ToDouble(textBox.Text))));
            }
		}

		private void rad_Click(object sender, RoutedEventArgs e)
		{
			radPressed = true;
		}

		private void degree_Click(object sender, RoutedEventArgs e)
		{
			degPressed = true;
		}
	}
}
