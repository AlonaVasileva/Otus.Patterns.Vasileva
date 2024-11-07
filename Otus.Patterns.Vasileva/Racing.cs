using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Patterns.Vasileva
{
    // Класс Racing, наследует от Alpine
    public class Racing : Alpine
    {
        public string CamberType { get; set; } // Тип прогиба (например, "rocker", "camber")

        public Racing(string brand, double length, string terrainType, string camberType)
            : base(brand, length, terrainType)
        {
            CamberType = camberType;
        }

        // Реализация клонирования
        public new Racing Clone()
        {
            return new Racing(this.Brand, this.Length, this.TerrainType, this.CamberType);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Camber: {CamberType}";
        }
    }
}
