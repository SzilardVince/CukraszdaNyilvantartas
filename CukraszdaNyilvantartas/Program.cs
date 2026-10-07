using CukraszdaNyilvantartas;

List<Sutemeny> sutik = new List<Sutemeny>();
double arak = 0;
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
    arak += sutik[i].Egysegar;
}
int osszeg = 0;
int teljes=0;
int listdb = sutik.Count;
Console.WriteLine("Pultban lévő sütemények");
for (int i = 0; i < listdb; i++)
{
    Console.WriteLine($"{sutik[i].Nev}: {sutik[i].Egysegar} FT  / db({sutik[i].RaktaronDb}db)->Összérték: {sutik[i].Egysegar * sutik[i].RaktaronDb}");
    teljes += (sutik[i].Egysegar * sutik[i].RaktaronDb);
}
double atlag = arak / listdb;
Console.WriteLine($"\nPult teljes készletértéke: {teljes} Ft");
Console.WriteLine($"Sütemények átlagos egységára: {atlag} Ft");
string status ="";
if(teljes>=40000)
{
    status = "Bőséges kínálat!";
}
else if (teljes>=20000)
{
    status = "Átlagos feltöltöttség.";
}
else
{
    status = "Alacsony készlet, utántöltés szükséges!";

}
Console.WriteLine($"Készlet státusza: {status}");