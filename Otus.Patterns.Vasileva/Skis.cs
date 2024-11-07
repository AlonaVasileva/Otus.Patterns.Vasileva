using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Patterns.Vasileva
{
    // Базовый класс для всех лыж
    public class Skis : IMyCloneable<Skis>, ICloneable
    {
        public string Brand { get; set; }
        public double Length { get; set; } 

        public Skis(string brand, double length)
        {
            Brand = brand;
            Length = length;
        }

        // Реализация клонирования через IMyCloneable
        public Skis Clone()
        {
            return new Skis(this.Brand, this.Length);
        }

        // Реализация клонирования через ICloneable
        object ICloneable.Clone()
        {
            return Clone();
        }

        public override string ToString()
        {
            return $"{Brand} Skis (Length: {Length} cm)";
        }
    }
}
