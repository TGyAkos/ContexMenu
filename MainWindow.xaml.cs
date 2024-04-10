using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace ContextMenu
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
        void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";

            if (dialog.ShowDialog() == true)
            {

                string fileName = dialog.FileName;
                string content = File.ReadAllText(fileName);
                textBox.Text = content;

            }
        }

        void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";

            if (dialog.ShowDialog() == true)
            {

                string fileName = dialog.FileName;
                File.WriteAllText(fileName, textBox.Text);


            }
        }
    }
}
