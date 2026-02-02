using KsiazkaKonsolowe4D;

string daneZPliku = File.ReadAllText("C:\\Users\\Student\\Desktop\\dane.txt");

string[] tablicaStron = daneZPliku.Split(';');

Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);
for(int i = 1; i < tablicaStron.Length; i++)
{
    ksiazka.DodajStrone(tablicaStron[i]);
}

foreach (Strona strona in ksiazka.strony)
{
    if (strona.numerStrony == 1) {
        Console.WriteLine($"[{strona.numerStrony}]: \n Tytul strony: {strona.trescStrony}"); 
    } else
    {
        Console.WriteLine($"[{strona.numerStrony}]: \n {strona.trescStrony}");
    } 
}