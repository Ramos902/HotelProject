namespace Entities
{
    class Peaple
    {
        private string StartName { get; set; }
        private string EndName { get; set; }

        public Peaple(string startName, string endName)
        {
            StartName = startName;
            EndName = endName;
        }

        public override string ToString()
        {
            return $"Name: {StartName} {EndName}";
        }
    }
}