/*Ex3
Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura
*/

Console.WriteLine("Introduceți un număr întreg:");
int numar = Convert.ToInt32(Console.ReadLine());

int ultimaCifra = numar % 10;

// Afisarea rezultatului
Console.WriteLine($"Ultima cifră a numărului este: {ultimaCifra}");
