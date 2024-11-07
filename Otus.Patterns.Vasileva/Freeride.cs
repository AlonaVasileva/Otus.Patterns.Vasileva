namespace Otus.Patterns.Vasileva
{
    // Класс Freeride, наследует от Alpine
    public class Freeride : Alpine
    {
        public string Flex { get; set; } // Жесткость лыж (например, "soft", "medium", "stiff")

        public Freeride(string brand, double length, string terrainType, string flex)
            : base(brand, length, terrainType)
        {
            Flex = flex;
        }

        // Реализация клонирования
        public new Freeride Clone()
        {
            return new Freeride(this.Brand, this.Length, this.TerrainType, this.Flex);
        }
                
        public override string ToString()
        {
            return $"{base.ToString()}, Flex: {Flex}";
        }
    }
}
