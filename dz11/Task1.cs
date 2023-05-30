using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    public class Piece : IDisposable
    {
        public StringBuilder title { get; set; }
        public StringBuilder PIB { get; set; }
        public Genre genre { get; set; }
        public StringBuilder year { get; set; }

        public void Show()
        {
            Console.WriteLine("Piece characteristics:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"PIB: {PIB}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Year: {year}");
        }
        public void Dispose()
        {
            title.Clear();
            PIB.Clear();
            genre = 0;
            year.Clear();
            Console.WriteLine("delete");
        }
        public Piece(string Title, string Pib, string Genre, int Year)
        {
            title = new StringBuilder(Title);
            PIB = new StringBuilder(Pib);
            genre = (Genre)Enum.Parse(typeof(Genre), Genre);
            year = new StringBuilder(Year.ToString());
            Console.WriteLine(" create");
        }
    }
    public enum Genre
    {

        Melodrama,
        Historical,
        Farce,
        Experimental,
        Morality,
        Tragedy,
        Comedy,
        Drama,

    }
}