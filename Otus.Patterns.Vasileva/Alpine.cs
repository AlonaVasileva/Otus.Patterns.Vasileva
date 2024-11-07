namespace Otus.Patterns.Vasileva
{
    public class Alpine : Skis
    {
        // Класс Alpine, наследует от Skis
        public string TerrainType { get; set; } // Тип местности (например, "mountain", "trail")

        public Alpine(string brand, double length, string terrainType)
            : base(brand, length)
        {
            TerrainType = terrainType;
        }

        // Реализация клонирования
        public new Alpine Clone()
        {
            return new Alpine(this.Brand, this.Length, this.TerrainType);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Terrain: {TerrainType}";
        }
    }

}
