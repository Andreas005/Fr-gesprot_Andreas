Console.WriteLine("Välkommen till Fotbollsfrågesporten! ");
Console.WriteLine("Det kommer inte vara så enkelt!");
int points = 0;

Console.WriteLine("Vilken Fotbollsspelare har gjort flest mål genom tiderna i top 5 ligorna! ");
Console.WriteLine("1 (Cristiano Ronaldo)  2 (Maradona) 3 (Lionel Messi) 4(Josef Bican)");

String Answer1 = Console.ReadLine();

if (Answer1 == "1")
{
    points++;
    Console.WriteLine("Bra Rätt svar!");
    Console.ReadLine();
    

}

else
{

    Console.WriteLine(("Dåligt val fel svar!"));
    Console.ReadLine();
    

}

Console.Clear();

Console.WriteLine("Till den andra Frågan");
Console.WriteLine("Vem har vunnit flest ballon di'ors i hela värdlen!");

Console.WriteLine("1 (Cristiano Ronaldo)  2 (Lionel Messi) 3 (Arjen Robben) ");

String Answer2 = Console.ReadLine();

if (Answer2 == "2")

{
    points++;
    Console.WriteLine("Rätt svar bra jobbat!");
    Console.ReadLine();
    
}

else 
{

    Console.WriteLine( "tyvär Fel svar!");
    Console.ReadLine();
    
}



Console.Clear();


Console.WriteLine("Nu till den sista frågan");
Console.WriteLine("Vem i världen har gjort den bästa frisparks målet!");

Console.WriteLine("( (1) Cristiano Rolando )  ((2) Lionel Messi )  ((3) Roberto Carlos)  ((4) Neymar JR)");

String Answer3 = Console.ReadLine();

if (Answer3 == "3")

{
    points++;
    Console.WriteLine("Rätt svar bra jobbat!");
    Console.ReadLine();
    
}

else 
{

    Console.WriteLine( "tyvär Fel svar!");
    Console.ReadLine();
    
}

Console.WriteLine("Ifall du har fått alla rätt utav de 3 frågorna så bjuder jag på pizza!");

Console.ReadLine();


Console.WriteLine($"Du har fått {points} poäng");

if (points == 3)
{
    Console.WriteLine("PIZZA");
}

Console.ReadLine();
