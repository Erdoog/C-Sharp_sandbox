using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Game
    {
        public string title;
        public double size;
        public string genre;
        public static double totalSize;
        public short hours;
        
        public Game(string ttl, double sz, string gnr, short hrs)
        {
            title = ttl;
            size = sz;
            genre = gnr;
            hours = hrs;
            totalSize += size;
        }
        public static double GetTotalSize()
        {
            return totalSize;
        }



/*            Console.Write("Enter the Title: ");
            Title = Console.ReadLine();
            Console.Write("Enter the size: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Genre: ");
            Genre = Console.ReadLine(); */





            /*            Game N002 = new Game();
                       Console.Write("Name f ur game: ");
                       N002.Title = Console.ReadLine();
                       Console.Write("Size f ur game (GBs): ");
                       N002.Size = Convert.ToInt32(Console.ReadLine());
                       Console.Write("Genre f ur game: ");
                       N002.Genre = Console.ReadLine(); */
        

    }
}