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
        public static string PathBookLibary = @"C:\mycode\Repos\sw_developer_2021_damian\src\20211021\Buchverwaltung_v1\Books" + BookInfos.BookTitel;

        public static bool BooknameFileExsist()
        {
            if (File.Exists(PathBookLibary))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void EveryBookToOwnFile()
        {
            File.WriteAllText(PathBookLibary, BookInfos.BookTitel);
        }
    }
    

}
