
using CarFuelEconomyApp;
using System.Runtime.CompilerServices;

Console.WriteLine("Witamy w programie obliczającym średnie zużycie paliwa samochodu.");
Console.WriteLine("==========================================");
Console.WriteLine("Wprowadź dane pojazdu (Marka i numer rejestracyjny");
string Brand = Console.ReadLine();
string Plate = Console.ReadLine();


CarTypeInFile cartype = new (Brand,Plate);

cartype.CarTypeAdded += CarType;
void CarType(object sender, EventArgs args)
{
    Console.WriteLine($"Wprowadzono dane pojazdu");
}




Console.WriteLine("Wprowadź przejechany dystans od ostatniego zatankowania samochodu do pełna");

while (true)
{
    Console.WriteLine("Podaj kolejny przejechany dystans lub naciśnij Q żeby wyjść ");
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
    if (statistics.Count != 0)

    {
        Console.WriteLine($"Podsumowanie dla : {cartype.Brand}  {cartype.Plate}");
        Console.WriteLine($"Liczba wpisów: {statistics.Count}. Suma przejechanych kilometrów: {statistics.Sum}");
        Console.WriteLine($"Średni przebieg pojazdu na jednym tankowaniu wyliczony z liczby wpisów: {statistics.Average:N2}");
        Console.WriteLine($"Najnizszy przebieg: {statistics.Min}");
        Console.WriteLine($"Najwyższy przebieg: {statistics.Max}");
    }
    

}

