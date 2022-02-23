using System;
using System.Collections;
using T4;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dominantHashTable = new Hashtable();  // Hashtable storing the card value which is dominant
            dominantHashTable.Add('A', 11);
            dominantHashTable.Add('K', 4);
            dominantHashTable.Add('Q', 3);
            dominantHashTable.Add('J', 20);
            dominantHashTable.Add('T', 10);
            dominantHashTable.Add('9', 14);
            dominantHashTable.Add('8', 0);
            dominantHashTable.Add('7', 0);

            Hashtable notDominantHashTable = new Hashtable(); // Hashtable storing the card value which is not dominant
            notDominantHashTable.Add('A', 11);
            notDominantHashTable.Add('K', 4);
            notDominantHashTable.Add('Q', 3);
            notDominantHashTable.Add('J', 2);
            notDominantHashTable.Add('T', 10);
            notDominantHashTable.Add('9', 0);
            notDominantHashTable.Add('8', 0);
            notDominantHashTable.Add('7', 0);
            string str = Console.ReadLine();
            int n = int.Parse(str.Split(' ')[0]);
            char dominant = str.Split(' ')[1][0];
            int totalScore = 0;
            for (int i = 0; i < 4 * n; i++)
            {
                string card = Console.ReadLine();
                if (card[1] == dominant)
                {
                    totalScore += (int)dominantHashTable[card[0]];
                }
                else
                {
                    totalScore += (int)notDominantHashTable[card[0]];
                }
            }
            Console.WriteLine(totalScore);

        }
    }
}
