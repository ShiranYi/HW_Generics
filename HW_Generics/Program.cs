

using System;

namespace HW_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeroesTable<Knight> ht1 = new HeroesTable<Knight>(5);
            Knight k1 = new Knight();
            Knight k2 = new Knight();
            ht1.Set(k1, 0);
            ht1.Set(k2, 2);
            Knight k3 = ht1[2];

            HeroesTable<Sword> ht2 = new HeroesTable<Sword>(6);
            Sword s1 = new Sword();
            Sword s2 = new Sword();
            ht2.Set(s1, 1);
            ht2.Set(s2, 3);
            Sword s3 = ht2[4];
        }
    }
}

