namespace Entities
{
    class Suite
    {
        private int IdSuite { get; set; }
        private string TypeSuite { get; set; }
        internal int Capacity { get; set; }
        internal decimal DiaryCost { get; set; }

        public Suite(int idSuite, string typeSuite, int capacity, decimal diaryCost)
        {
            IdSuite = idSuite;
            TypeSuite = typeSuite;
            Capacity = capacity;
            DiaryCost = diaryCost;
        }

        public override string ToString()
        {
            return $"=======| Suite |=======\nIDSuite: {IdSuite}\nType: {TypeSuite}\nCapacity: {Capacity}\nDiary Cost: {DiaryCost}";
        }
    }
}