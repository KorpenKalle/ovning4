using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Övning 1: ExamineList
        ExamineList();

        // Övning 2: ExamineQueue
        ExamineQueue();

        // Övning 3: ExamineStack
        ExamineStack();

        // Övning 4: CheckParenthesis
        CheckParentheses();

        // ... Fler övningar om tid finns ...
    }

    // Övning 1: ExamineList
    static void ExamineList()
    {
        List<int> numbers = new List<int>();
        // Skriver ut listans kapacitet innan vi lägger till element
        Console.WriteLine($"Initial capacity: {numbers.Capacity}");

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i);
            Console.WriteLine($"Capacity after adding {i}: {numbers.Capacity}");
        }

        // 2. När ökar listans kapacitet? 
        // När den nuvarande kapaciteten har överstigits, vilket kräver en ny allokering

        // 3. Med hur mycket ökar kapaciteten?
        // Vanligtvis dubblas kapaciteten, men kan variera

        // 4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
        // För att minimera minnesallokering och förbättra prestanda

        // 5. Minskar kapaciteten när element tas bort ur listan?
        // Ja, men det görs sällan automatiskt. En egendefinierad metod kan användas för att
        // minska kapaciteten om önskas

        // 6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
        // Om man vet mängden element i förväg eller om minnesprestanda är en kritisk faktor
    }

    // Övning 2: ExamineQueue
    static void ExamineQueue()
    {
        Queue<string> queue = new Queue<string>();

        // Simulerar ICA-kön med en kö
        queue.Enqueue("Kalle");
        queue.Enqueue("Greta");
        Console.WriteLine(queue.Dequeue() + " lämnar kön."); // Kalle
        queue.Enqueue("Stina");
        Console.WriteLine(queue.Dequeue() + " lämnar kön."); // Greta
        queue.Enqueue("Olle");

        // Flera dequeue-anrop kan göras för att simulera fler expedieringar
    }

    // Övning 3: ExamineStack
    static void ExamineStack()
    {
        Stack<string> stack = new Stack<string>();

        // Simulerar ICA-kön med en stack (Exempelvis)
        stack.Push("Kalle");
        stack.Push("Greta");
        Console.WriteLine(stack.Pop() + " lämnar kön."); // Greta, felaktigt

        // Stackar bör inte användas för köhantering eftersom:
        // 1. Det fungerar enligt LIFO - Först in, sist ut (vilken inte stämmer överens med FIFO)
    }

    // Övning 4: CheckParenthesis
    static void CheckParentheses()
    {
        Console.WriteLine("Skriv in en sträng för att kontrollera parenteser:");
        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();
        bool isValid = true;

        foreach (char c in input)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }

                char top = stack.Pop();
                if (!IsMatchingPair(top, c))
                {
                    isValid = false;
                    break;
                }
            }
        }

        if (isValid && stack.Count == 0)
        {
            Console.WriteLine("Strängen är välformad.");
        }
        else
        {
            Console.WriteLine("Strängen är inte välformad.");
        }
    }

    static bool IsMatchingPair(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '{' && closing == '}') ||
               (opening == '[' && closing == ']');
    }

    // Observera: Rekursion och iteration är inte implementerade här, men se till att
    // utföra dessa övningar med liknande tillvägagångssätt för att se skillnader i minneshantering.
}

