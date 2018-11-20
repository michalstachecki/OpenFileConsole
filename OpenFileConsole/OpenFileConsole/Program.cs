using System;
using System.Windows.Forms;

namespace OpenFileConsole
{
    class Program
    {
        [STAThread]
        private static void Main()
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = false
            };

            var openFileDialogResult = openFileDialog.ShowDialog();
            if (openFileDialogResult == DialogResult.OK)
            {
                Console.WriteLine($"Opened file {openFileDialog.FileName}");
            }
            else
            {
                Console.WriteLine("File not selected");
            }

            Console.ReadLine();
        }
    }
}
