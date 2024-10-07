using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace cSharpPracticeCoding
{
    class BirthPlace
    {
        public  virtual void showInfo()
        {
            Console.WriteLine("Our Birth Place is Bangladesh");
        }
    }
    class Dhaka  :BirthPlace
    {
        public void showInfo()
        {
            Console.WriteLine("Our Birth Place is Dhaka");
        }
    }
    class Khulna : BirthPlace
    {
        public override void showInfo()
        {
            Console.WriteLine("Our Birth Place is Khulna");
        }
    }
    class Rajshahi : BirthPlace
    {
        public override void showInfo()
        {
            Console.WriteLine("Our Birth Place is Rajshahi");
        }
    }
    class Polymorph
    {
        static void Main(string[] args)
        {
            BirthPlace birthPlace = new BirthPlace();
            BirthPlace dhaka= new Dhaka();// Though Dhaka class defin the place as Dhaka but it'll result the base class result as it doesn't override
            Khulna khulna = new Khulna();
            Rajshahi rajshahi = new Rajshahi();
            birthPlace.showInfo();
            dhaka.showInfo();
            khulna.showInfo();
            rajshahi.showInfo();
        }
    }
}
