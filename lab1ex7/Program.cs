/*
* Se citesc doua numere de la tastatura, x si y.
* Scrieti un program care va verifica daca x este divizil cu y
* In cazul in care "x" este divizibil cu "y", programul va afisa "divizibil", iar in caz contrar, "indivizibil"
*/

Console.WriteLine("Introduceti valoarea pentru x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentry y:");
int y = int.Parse(Console.ReadLine());


if (x % y == 0)
{
    Console.WriteLine("divizil");
}
else
{
    Console.WriteLine("indivizil");
}