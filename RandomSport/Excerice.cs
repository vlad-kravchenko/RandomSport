namespace RandomSport
{
    class Excerice
    {
        public Group Group { get; set; }
        public string Name { get; set; }
        public Measurement Measure { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public bool TwoSides { get; set; }
        public int Current { get; set; }

        public Excerice(Group group, string name, Measurement measure, int min, int max, bool twoSides = false)
        {
            Group = group;
            Name = name;
            Measure = measure;
            Min = min;
            Max = max;
            TwoSides = twoSides;
        }
    }
}