namespace Entities
{
    class Suite
    {
        private string TipoSuite { get; set; }
        private int Capacity { get; set; }
        private decimal DiaryCost { get; set; }

        public Suite(string tipoSuite, int capacity, decimal diaryCost)
        {
            TipoSuite = tipoSuite;
            Capacity = capacity;
            DiaryCost = diaryCost;
        }

        public override string ToString()
        {
            return $"";
        }
    }
}