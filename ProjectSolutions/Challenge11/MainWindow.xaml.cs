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

namespace Challenge11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {
            string InputString = StringInputTb.Text;
            string RegexString = RegexInputTb.Text;
            
            Regex Pattern = new Regex(RegexString);

            string Output = Pattern.Match(InputString).ToString();
            RegexOutputTb.Text = !string.IsNullOrEmpty(Output) ? Output : "Could not match the string to the provided Regex Pattern";
        }
    }
}
