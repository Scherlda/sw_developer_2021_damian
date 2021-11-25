using System;

namespace FormsGL
{
    public interface IBook
    {
        string Author { get; set; }
        string Publisher { get; set; }
        string Titel { get; set; }
        DateTime YearOfPublication { get; set; }
    }
}