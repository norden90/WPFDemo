using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                if (btn.Content != null)
                    MinText.Text = btn.Content.ToString();
                
                
            }
            else
            {

            }
            MinText.Text = Input.Text;
        }

        private void IncreaseFontSize(object sender, RoutedEventArgs e)
        {
            MinText.FontSize += 10;
        }

        private void LowerFontSize(object sender, RoutedEventArgs e)
        {
            MinText.FontSize -= 10;
        }

        private void FontComic(object sender, RoutedEventArgs e)
        {
            MinText.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void FontCon(object sender, RoutedEventArgs e)
        {
            MinText.FontFamily = new FontFamily("Consolas");
        }
    }
    
}
