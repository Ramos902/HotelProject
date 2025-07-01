using System.Globalization;
using Entities;

namespace HotelProject.Entities
{
    class Reservations
    {
        private List<Peaple> Guests { get; set; }
        private Suite Suite { get; set; }
        private int ReservedDays { get; set; }
        public override string ToString()
        {
            return $"=======| Reservation |=======\nQty Guests: {GetQuantityGuests()}\nReserved Days: {ReservedDays}";
        }

        public Reservations(Suite suite, int reservedDays)
        {
            Suite = suite;
            ReservedDays = reservedDays;
            Guests = new();
        }
        public void AddSuite(Suite suite)
        {
            Suite = suite;

        }
        public void AddGuests(Peaple peaple)
        {
            try
            {
                if (Suite != null)
                {
                    if (Guests.Count >= Suite.Capacity)
                    {
                        throw new Exception("Guests capacity exceeds room capacity!");
                    }
                    else
                    {
                        Guests.Add(peaple);
                        System.Console.WriteLine($"Pessoa adicionada: {peaple.ToString()}");
                    }
                }
                else
                {
                    throw new Exception("Any Suite has been declareted!");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            
        }
        public int GetQuantityGuests()
        {
            return Guests.Count;
        }
        public decimal CalculateDiaryCost()
        {
            if (ReservedDays >= 10)
            {
                return ReservedDays * Suite.DiaryCost * 100 / 110;
            }
            else
            {
                return ReservedDays * Suite.DiaryCost;    
            }
            
        }
    }
}