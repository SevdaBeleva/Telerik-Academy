using System;
class MissCat
{
    static void Main(string[] args)
    {
        int judges = int.Parse(Console.ReadLine());
        int[] cats = new int[11];

        for (int i = 0; i < judges; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            cats[vote]++;
        }

        int countVotes = 0;
        int winner = 0;

        for (int i = 0; i < cats.Length; i++)
        {
            if (cats[i] > countVotes)
            {
                countVotes = cats[i];
                winner = i;
            }
        }
        Console.WriteLine(winner);
    }
}

