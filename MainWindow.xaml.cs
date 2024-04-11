using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_L3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        } // MainWindow


        private void btnDisplayInformation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Steps
                // 1. Create string variables for our first and last name
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                
                // Testing to see if
                //int number = int.Parse(firstName) / int.Parse(lastName);
                // 2. Concatenate them together to form a full name
                // string interpolation
                string fullName = $"{firstName} {lastName}";

                // Rich Text Box

                // 3. Display that information to our label
                lblDisplayFullName.Content = fullName;

                // 4. Display to the Rich Text Box
                runDisplay.Text = fullName;

                // x - Add a new Rich Text Box for getting an address
                // x - Add a label for the Rich Text box
                // x - Properly name the "Run" tag
                // Write the code to grab the text from RTB
                string address = runHomeInfo.Text;
                // Display it to our original runDisplay

                // Two line breaks
                runDisplay.Text += "\n\n";

                // Append the Address
                runDisplay.Text += address;

                // Full Name
                // 
                // Address


            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.ToString());
            }
            catch (DivideByZeroException dvz)
            {
                MessageBox.Show("You cannot divide by zero");
            }


            // DivideByZero is for the homework
 

        }

        // THis is a demonstration of a summary comment below

        /// <summary>
        /// Test method to demonstrate what summary is
        /// </summary>
        /// <param name="number1">Number to pass in</param>
        /// <param name="word1">Word to pass in</param>
        /// <returns>Returning the formatted word</returns>
        public string TestMethod(int number1, string word1)
        {
            return "";
        }

    } // class

} // namespace