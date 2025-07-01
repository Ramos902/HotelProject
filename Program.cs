using Entities;
using Utilities;

namespace HotelProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instance the Suite's
            Suite s1 = new(0, "Luxo", 8, 200);

            //Instance the Reservation for Suite
            Reservations reservation1 = new(s1, 5);

            //Adding Peoples instances
            reservation1.AddGuests(new("João", "Ramos"));
            reservation1.AddGuests(new("Ana", "Laura"));
            reservation1.AddGuests(new("José", "Otavio"));

            //==============================================        
            //Instance the Suite's
            Suite s2 = new(1, "Normal", 4, 80);

            //Instance the Reservation for Suite    
            Reservations reservation2 = new(s2, 3);

            //Adding Peoples instances
            reservation2.AddGuests(new("João", "Ramos"));
            reservation2.AddGuests(new("Ana", "Laura"));
            reservation2.AddGuests(new("José", "Otavio"));
            reservation2.AddGuests(new("João", "Ramos"));
            reservation2.AddGuests(new("Ana", "Laura"));
            reservation2.AddGuests(new("José", "Otavio"));

            System.Console.WriteLine(reservation1.ToString());
            System.Console.WriteLine(s1.ToString());
            System.Console.WriteLine(reservation1.CalculateDiaryCost());

            System.Console.WriteLine("\n");

            System.Console.WriteLine(reservation2.ToString());
            System.Console.WriteLine(s2.ToString());
            System.Console.WriteLine(reservation2.CalculateDiaryCost());
        }
    }
}