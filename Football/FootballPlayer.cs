using System;

namespace Football
{
    public class FootballPlayer
    {
        private string _name;
        private int _price;
        private int _shirtNumber;
        public static int NextId = 1;
        public int Id { get; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) { throw new ArgumentOutOfRangeException(); }
                _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) { throw new ArgumentOutOfRangeException(); }
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100) { throw new ArgumentOutOfRangeException(); }
                _shirtNumber = value;
            }
        }

        public FootballPlayer(string name, int price, int shirtNumber)
        {
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
            Id = NextId;
            NextId++;
        }
    }
}
