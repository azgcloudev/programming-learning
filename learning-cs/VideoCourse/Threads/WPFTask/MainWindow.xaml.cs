using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WPFTask
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


        /*
        private void MyButton_Clicked(object sender, RoutedEventArgs e)
        {
            string url = "http://ipv4.download.thinkbroadband.com/20MB.zip";

            Task.Run(() =>
            {
                Debug.WriteLine($"Initial thread number {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                try
                {
                    string html = webClient.GetStringAsync(url).Result;

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Task was not completed. Error: {ex.Message}");
                }

                MyButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Current dispatcher thread: {Thread.CurrentThread.ManagedThreadId}");
                    MyButton.Content = "Done";
                });
            });
        }
        */

        /*
        // using Task and async and await
        private async void MyButton_Clicked(object sender, RoutedEventArgs e)
        {
            string url = "https://ash-speed.hetzner.com/100MB.bin";

            Debug.WriteLine($"Initial thread {Thread.CurrentThread.ManagedThreadId}");
            HttpClient webClient = new HttpClient();

            await Task.Run(() =>
            {   Debug.WriteLine($"Task thread = {Thread.CurrentThread.ManagedThreadId}");
                var html = webClient.GetAsync(url).Result;

                Debug.WriteLine($"Task thread = {Thread.CurrentThread.ManagedThreadId} is completed");
            });

            MyButton.Content = "Done";
        }
        */

        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));

        private async void MyButton_Clicked(object sender, RoutedEventArgs e)
        {
            string myHtml = string.Empty;

            await Task.Run(() =>
            {
                HttpClient httpClient = new HttpClient();
                string html = httpClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });

            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }
    }
}
