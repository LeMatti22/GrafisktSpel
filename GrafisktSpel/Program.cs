using System;

string room = "spelrum";
string nödig = "pissnödig";

while (room == "spelrum")
{
    if (nödig == "pissnödig")
    {
        Console.WriteLine("Du är pissnödig, gå till toaletten");
        Console.WriteLine("tryck på en knapp för att gå ut i hallen");
        Console.ReadKey();
        room = "hallen";
        Console.Clear();
    }
    
    else if (nödig == "spelnödig")
    {
        Console.WriteLine("Du är spelnödig så du sätter dig och spelar");
    }
}

while (room == "hallen")
{
    if (nödig == "pissnödig")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("tryck på en knapp för att gå in på toan");
        Console.ReadKey();
        room = "toalett";
        Console.Clear();
    }

        else if (nödig == "spelnödig")
    {
        Console.WriteLine("Du är i hallen och är spelnödig");
        Console.WriteLine("klicka på en knapp för att gå in i spelrummet");
        Console.ReadKey();
        room = "spelrum";
        Console.Clear();
    }
}

while (room == "toalett")
{
    if (nödig == "pissnödig")
    {
        Console.WriteLine("Du är på toa");
        Console.WriteLine("tryck på en knapp för att pissa");
        Console.ReadKey();
        nödig = "spelnödig";
        Console.Clear();
    }

    else if (nödig == "spelnödig")
    {
        Console.WriteLine("Du är på toa");
        Console.WriteLine("Du är spelnödig tryck på en knapp för att börja gå tillbaks till spelrummet");
        Console.ReadKey();
        room = "hallen";
        Console.Clear();
    }
}