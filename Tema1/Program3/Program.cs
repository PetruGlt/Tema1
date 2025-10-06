using System;

string[] studenti = new string[10];
string? nume;

while (true)
{
    Console.WriteLine();
    nume = Console.ReadLine();
    if (nume == "exit")
    {
        for (int i = 0; i < studenti.Length; i++)
        {
            if (studenti[i] != null)
            {
                Console.WriteLine(studenti[i]);
            }
        }
        return;
        
    }
        
    studenti = studenti.Append(nume).ToArray();
    
    Console.WriteLine("Student adaugat");
    
}
    
