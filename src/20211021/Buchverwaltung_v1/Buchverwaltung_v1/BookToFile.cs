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
        //Cut all whitespaces out of string
        public static string fileSaveName = String.Concat(BookInfos.BookTitel.Where(c => !Char.IsWhiteSpace(c)));
        //Path where the File lies
        public static string PathBookLibary = $@"C:\mycode\Repos\sw_developer_2021_damian\src\20211021\Buchverwaltung_v1\Books\{fileSaveName}.book";

       //Writes all data to File
        public static void EveryBookToOwnFile()
        {
            File.WriteAllText(PathBookLibary, $"{ BookInfos.BookTitel}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookAutor}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookNumberPages.ToString()}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookYearOfPublication.ToString("yyyy")}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.BookPrice.ToString()}\n");
            File.AppendAllText(PathBookLibary, $"{ BookInfos.CustomerIBAN}\n");
        }
        
    }
    

}
