using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Buchverwaltung_v1
{
    internal class BookToFile
    {
        public static string PathBookLibary = $@"C:\mycode\Repos\sw_developer_2021_damian\src\20211021\Buchverwaltung_v1\Books\{BookInfos.BookTitel.Trim()}.book";

       
        public static void EveryBookToOwnFile()
        {
            File.WriteAllText(PathBookLibary, $"{ BookInfos.BookTitel}\n");
            //File.AppendAllText(PathBookLibary, $"{ BookInfos.BookTitel}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookAuthor}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookNumberPages.ToString()}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookYearOfPublication.ToString("yyyy")}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookPrice.ToString()}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.CustomerIBAN}\n");
        }
    }
    

}
