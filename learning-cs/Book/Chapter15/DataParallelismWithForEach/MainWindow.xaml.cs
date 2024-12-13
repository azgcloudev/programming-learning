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
using System.Drawing;
using System.IO;
using Path = System.IO.Path;

namespace DataParallelismWithForEach;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void cmdCancel_Click(object sender, RoutedEventArgs e)
    {
    }

    private void cmdProcess_Click(object sender, RoutedEventArgs e)
    {
        this.Title = $"Starting...";
        // using task class to avoid blocking the primary thread so the app can still received input text while updating the images
        Task.Factory.StartNew(() => ProcessFiles());
        //Task.Factory.StartNew(ProcessFiles); // can be written also like this
    }

    private void ProcessFiles()
    {
        string basePath = Directory.GetCurrentDirectory();
        string pictureDirectory = @"C:\Users\aldai\Pictures\Screenshots";
        string outputDirectory = Path.Combine(basePath, "modifiedPictures");

        // clear any existing files
        if (Directory.Exists(outputDirectory))
        {
            Directory.Delete(outputDirectory, true);
        }

        Directory.CreateDirectory(outputDirectory);
        string[] files = Directory.GetFiles(pictureDirectory, "*.png", SearchOption.AllDirectories);

        /* *** process image data in a blocking manner
         * 
        foreach (string currentFile in files)
        {
            string fileName = Path.GetFileName(currentFile);
            // print the ID of the thread processing the image
            this.Title = $"Processing {fileName} on thread {Environment.CurrentManagedThreadId}";
            using (Bitmap bitmap = new Bitmap(currentFile))
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                bitmap.Save(Path.Combine(outputDirectory, fileName));
            }
        }
        */

        // process the images in a parallel manner
        Parallel.ForEach(files, file =>
        {
            string fileName = Path.GetFileName(file);

            // allow the secondary thread to access the main thread (UI) to update in a safely manner
            Dispatcher?.Invoke(() =>
            {
                this.Title = $"Processing image {fileName} on thread {Environment.CurrentManagedThreadId}";
            });

            using (Bitmap bitmap = new Bitmap(file))
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                bitmap.Save(Path.Combine(outputDirectory, fileName));
            }
        });
    }
}