using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Square cla  = new Square(2);
            Rectangular rec = new Rectangular("KVADRAT","DUZBUCAQLI");
            int key = 0;
            do
            {
                Console.WriteLine("Reqem daxil edin:");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        {
                            cla.ClacArea();
                        }
                        break;
                    case 2:
                        {
                            rec.ClacArea();
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine("prqram sonlandi");
                        }
                        break;
                }
            } while (key != 3);
            
        }
    }
    abstract class Figure
    {
        public abstract void ClacArea();
    }
    class Square:Figure
    {
        public int side;
       public Square(int side)
        {
            this.side = side;
           
        }
        public override void ClacArea()
        {
            Console.WriteLine("side");
        }

    }
    class Rectangular:Figure
    {
        public string width;
        public string length;
        public Rectangular(string width, string length)
        {
            this.width = width;
            this.length = length;
        }
        public override void ClacArea()
        {
            Console.WriteLine($"width" + "length");
        }
    }
}
