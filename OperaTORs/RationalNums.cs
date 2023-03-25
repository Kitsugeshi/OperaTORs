using System;
using System.Collections.Generic;
using System.Text;

namespace OperaTORs
{
    class RationalNums
    {
        private int chis;
        private int znam;
        
        public int Chis
        {
            get
            {
                return chis;
            }
            set
            {
                chis = value;
            }
        }

        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                znam = value;
            }
        }
        public RationalNums(int chislitel = 1, int znamenatel = 1)
        {
            if (znamenatel == 0)
            {
                throw new ArgumentException("Знаменатель не может быть нулём, ёлки-палки. Хочешь, чтобы вселенная схлопнулась?");
            }
            chis = chislitel;
            znam = znamenatel;
        }

        public static RationalNums operator +(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            if (a.Znam == b.Znam)
            {
               res.Chis = a.Chis + b.Chis;
               res.Znam = a.Znam;
            }
            else
            {
                res.Chis = a.Chis * b.Znam + a.Znam * b.Chis;
                res.Znam = a.Znam * b.Znam;
            }
            return res;
        }

        public static RationalNums operator -(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            if (a.Znam == b.Znam)
            {
                res.Chis = a.Chis - b.Chis;
                res.Znam = a.Znam;
            }
            else
            {
                res.Chis = a.Chis * b.Znam - a.Znam * b.Chis;
                res.Znam = a.Znam * b.Znam;
            }
            return res;
        }

        public static RationalNums operator *(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            res.Chis = a.Chis * b.Chis;
            res.Znam = a.Znam * b.Znam;
            return res;
        }

        public static RationalNums operator /(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            res.Chis = a.Chis * b.Znam;
            res.Znam = a.Znam * b.Chis;
            return res;
        }
        public void Print()
        {
            if (chis < 0)
            {
                Console.WriteLine($"-({-chis}/{znam})");
            }
            else Console.WriteLine($"{chis}/{znam}");
        }
    }
}

// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
