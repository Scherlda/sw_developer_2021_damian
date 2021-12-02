using BookManager.StorageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var storage = new XmlStorage();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookManager(storage)); //nachdem in BookMaanger auf IStorage umgestellt wurde muss hier (storage) mitgegeben werden.
        }



    }
}
