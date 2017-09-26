namespace Lab60
{
    class Car
    {
       public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }
    
    }

    public enum CarColor { blue, white, black, red, yellow };
}
