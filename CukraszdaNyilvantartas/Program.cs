using CukraszdaNyilvantartas;

List<Sutemeny> sutik = new List<Sutemeny>();
for (int i= 0; i < 4; i++)
{
    Sutemeny aktualis = new Sutemeny();
    Console.WriteLine($"{i+1}. sütemény adatai:");
    Console.Write($"\tNév: ");
    aktualis.Nev = Console.ReadLine();
    Console.Write($"\tEgységár (Ft): ");
    aktualis.Egysegar = int.Parse(Console.ReadLine());
    Console.Write($"\tRatáron (db): ");
    aktualis.RaktaronDb = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    sutik.Add(aktualis);
}