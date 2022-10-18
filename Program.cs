//Kent Tupas
//10/18/2022
// github mini challenge 5
// update and upload to github
//

string input, adjectives1, adjectives2, adjectives3, adjectives4, adjectives5, verb1, verb2, verb3;

Console.Clear();
Console.WriteLine("Hello Fellow User");
Console.WriteLine("Want to make a story");
input = Console.ReadLine();
while(input != "no"){
    Console.WriteLine("Give a name for your character");
    string name1 = Console.ReadLine();

    Console.WriteLine("Give 5 Adjectives");
     adjectives1 = Console.ReadLine();
     adjectives2 = Console.ReadLine();
     adjectives3 = Console.ReadLine();
     adjectives4 = Console.ReadLine();
     adjectives5 = Console.ReadLine();

    Console.WriteLine("Give 3 verbs ending with -ing");
     verb1 = Console.ReadLine();
     verb2 = Console.ReadLine();
     verb3 = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"This morning {name1} woke of feeling {adjectives1}. Looking outside thinking its going to be a {adjectives2} day! Walking through the city everyone is {verb1} away from something. All {name1} saw was a {adjectives3} beam. Suddenly I blacked out. Walking up in a {adjectives4} chamber. {name1} {verb2} out of this building and went in to the city. All I see is women, no men in sight. They all {verb3} up to me looking {adjectives5} at me. I asked them what happen to all the men in the world. Now this is a world where women ruled the world.");
    Console.WriteLine();
    Console.WriteLine("Type yes to try again or type no to stop");
    input = Console.ReadLine();
}