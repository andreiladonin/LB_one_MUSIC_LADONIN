using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant25_music
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicClassic music = new MusicClassic("Бетховен", 1900);

            music.MusicMethod();


            Console.Read();
        }
    }

    class Music
    {
        protected string Name { get; set; }
        protected int Years { get; set; }

        public Music(string name, int years)
        {
            Name = name;
            Years = years;
            Console.WriteLine("Родительский класс создан");
        }

        public virtual void MusicMethod()
        {
            Console.WriteLine("Музыка: {0}, {1} года, лучшее что мы слышали ", Name, Years);
        }
    }

    class MusicClassic : Music
    {
        public MusicClassic(string name, int years) : base(name, years)
        {
            Name = name;
            Years = years;

            Console.WriteLine("Дочерний класс ссоздан");
        }

        public override void MusicMethod()
        {
            Console.WriteLine("Классика {0}, {1} всегда будет вечна", Name, Years);
        }
    }
}
