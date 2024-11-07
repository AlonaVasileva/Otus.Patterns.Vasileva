using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Patterns.Vasileva
{
    // Класс Freestyle, наследует от Alpine
    public class Freestyle : Alpine
    {
        public string Bindings { get; set; } // Тип креплений (например, "step-in", "traditional")

        public Freestyle(string brand, double length, string terrainType, string bindings)
            : base(brand, length, terrainType)
        {
            Bindings = bindings;
        }

        // Реализация клонирования
        public new Freestyle Clone()
        {
            return new Freestyle(this.Brand, this.Length, this.TerrainType, this.Bindings);
        }
       
        public override string ToString()
        {
            return $"{base.ToString()}, Bindings: {Bindings}";
        }
    }
}
