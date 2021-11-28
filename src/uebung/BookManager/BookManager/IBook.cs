using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public interface IBook
    {
        string Title { get; set; }
        string Autor { get; set; }
        string Publisher { get; set; }
        string AgeRating { get; set; }
        string Languages { get; set; }
        string YearOfPublication { get; set; }


    }
}
