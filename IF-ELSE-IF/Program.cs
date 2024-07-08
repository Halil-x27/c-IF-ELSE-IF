using System;

namespace if_elseif
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>6 && time<11)
            {
                Console.WriteLine("Günaydin");
            }
            else if (time<=18)
            {
                Console.WriteLine("iyi günler");
            }
            else{
                Console.WriteLine("iyi geceler");
            }

            string sonuc = time<=18 ? "iyi günler" : "iyi geceler";

            sonuc = time>=6 && time<11 ? "günaydin" : time<=18 ? "iyi günler" : "iyi geceler";

            Console.WriteLine(sonuc);
        }
    }
}