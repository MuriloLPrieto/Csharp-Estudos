using CriandoExecoes.Entities;
using CriandoExecoes.Entities.Exceptions;

try
{
    Console.Write("Room Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine(reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine(reservation);
}
catch (DomainException date)
{
    Console.WriteLine("Error in reservation: " + date.Message);
}
catch (FormatException e) 
{
    Console.WriteLine("Format error: " + e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Error!" + e.Message);
}