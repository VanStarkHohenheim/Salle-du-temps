string[] voy = {"a", "e", "i", "o", "u", "y"}; 
Console.WriteLine("bonjour entrez votre phrases");
string phrase = Console.ReadLine();

int nb = 0;

for (int cpt = 0; phrase.Length > cpt; cpt++  )
{
    if (voy.Contains(phrase[cpt].ToString().ToLower()))
    {
        nb++;
    }
}

Console.WriteLine($"voici le nb de voyelle {nb}");
