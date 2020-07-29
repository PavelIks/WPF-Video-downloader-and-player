using System;
using System.Net;
using System.Windows;

namespace VideoDownloadAndPlayback
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFileCompleted += delegate { };
            client.DownloadFile("https://r1---sn-4g5e6nzs.googlevideo.com/videoplayback?expire=1596067022&ei=brghX6ebIYSF8gPd_6P4Cg&ip=95.211.196.30&id=o-AKzMFSPPU05a1BQ7hyM0EM2omuMMwP72jfM7oqXtNcPh&itag=22&source=youtube&requiressl=yes&mh=cx&mm=31%2C26&mn=sn-4g5e6nzs%2Csn-2gb7sn7s&ms=au%2Conr&mv=m&mvi=1&pl=23&initcwndbps=22500&vprv=1&mime=video%2Fmp4&ratebypass=yes&dur=15.069&lmt=1577397909046527&mt=1596045277&fvip=1&fexp=23883098&c=WEB&txp=2211222&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRgIhAJ8rE3hQ65wJq81jYj6epY296NyX08ASN5TvtvlFj2eIAiEAg8OtibjAFAn7C1MHC2Gd2Zp0Y7JUAIZydUeaHqFtymo%3D&lsparams=mh%2Cmm%2Cmn%2Cms%2Cmv%2Cmvi%2Cpl%2Cinitcwndbps&lsig=AG3C_xAwRAIgBr373RX-mvemG7EglNb20r5cEG8MR7ucj9kcAj3M5XkCIFsHOWiDRCpiRUV6VKj1ypM7jHiuY1_OTzO1RG6VCv3-&contentlength=1818210&video_id=dzx-i9AqLZo&title=Hello+There+but+Obi-Wan+falls+through+the+floor", "Test1" + ".mp4");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            OK.Source = new Uri(@"C:\Users\Pavlo\source\repos\VideoDownloadAndPlayback\bin\Debug\Test1.mp4");
        }
    }
}