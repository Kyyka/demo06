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

namespace teht03
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int width = int.Parse(WidthTextBox.Text);
            int height = int.Parse(HeightTextBox.Text);
            int frame = int.Parse(FrameTextBox.Text);
            
            //WindowArea
            int WindowArea = width * height / 10;
            WindowAreaTextBox.Text = WindowArea.ToString() + " cm^2";

            //GlassArea
            int GlassArea = (width - frame * 2) * (height - frame * 2) / 10;
            GlassAreaTextBox.Text = GlassArea.ToString() + " cm^2";

            //FrameCircle
            int FrameCircle = (width / 10 * 2) + (height / 10 * 2);
            FrameCircleTextBox.Text = FrameCircle.ToString() + " cm";
            
        }
    }
}
