﻿
using CarFuelEconomyApp;
using System.Runtime.CompilerServices;

Console.WriteLine("Witamy w programie obliczającym średnie zużycie paliwa samochodu.");
Console.WriteLine("==========================================");


Console.WriteLine("Wprowadź dane pojazdu (Marka i numer rejestracyjny");
string Brand = Console.ReadLine();
string Plate = Console.ReadLine();


CarTypeInFile cartype = new CarTypeInFile(Brand, Plate) ;
cartype.CarTypeAdded += CarType;
void CarType(object sender, EventArgs args)
{
    Console.WriteLine($"Wprowadzono dane pojazdu");


    Console.WriteLine(Brand);
    Console.WriteLine(Plate);
}

Console.WriteLine();
Console.WriteLine("Wprowadź przejechany dystans od ostatniego zatankowania samochodu do pełna");
string distance = Console.ReadLine();


 Console.ReadLine();
Console.WriteLine("Wprowadź ilość litrów zatankowanego paliwa");
string volume = Console.ReadLine();






while (true)
{
    Console.WriteLine("Wprowadź ilość zatankowanego paliwa");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        cartype.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wystąpił błąd wyjątku: {ex.Message}");
    }

    var statistics = cartype.GetStatistics();

    {


        Console.WriteLine($"Podsumowanie dla : {Brand}   {Plate}");
        Console.WriteLine($"Liczba przejechanych kilometrów: {statistics.Distance}. Ilość litrów: {statistics.Volume}");
        Console.WriteLine($"Średnia zużycie paliwa na 100km: {statistics.Average:N2}");
    }

}
