// Could still use a place to store and pull results. Needs a lot more functionality, even if just for me. 


// initialize the dice object using the Random() method.
Random dice = new Random();

//random roles between 1 and 6
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// add 'em up
int total = roll1 + roll2 + roll3;

// Display what was rolled and the total
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// This is the bonus logic.
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
// This gives the prize output at the end
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
