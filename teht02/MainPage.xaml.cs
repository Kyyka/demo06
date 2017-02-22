using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace teht02
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //EuroTextBox empty by clicking
        public void EuroTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= EuroTextBox_GotFocus;
        }
        //EuroTextBox filled with "Eurot" if clicked somewhere else
        public void EuroTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EuroTextBox.Text == "")
            {
                EuroTextBox.Text = "Eurot";
            }
        }

        //MarkkaTextBox empty by clicking
        public void MarkkaTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= MarkkaTextBox_GotFocus;
        }
        //MarkkaTextBox filled with "Markat" if clicked somewhere else
        public void MarkkaTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (MarkkaTextBox.Text == "")
            {
                MarkkaTextBox.Text = "Markat";
            }
        }

        private void EuroButton_Click(object sender, RoutedEventArgs e)
        {
            double euro = double.Parse(EuroTextBox.Text) * 6.0;
            string euro_s = euro.ToString("0.00");
            EuroTextBox.Text = euro_s;
        }

        private void MarkkaButton_Click(object sender, RoutedEventArgs e)
        {
            double markat = double.Parse(MarkkaTextBox.Text) / 6.0;
            string markat_s = markat.ToString("0.00");
            MarkkaTextBox.Text = markat_s;
        }
    }
}
