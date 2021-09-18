using System;
namespace Election
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nameArray;
            String[] partyArray;
            int[] voteArray;
            String name = "";
            int maxIndex = 0, maxVote = 0;

            int n, x, n1;
            n = int.Parse(Console.ReadLine());

            nameArray = new String[n];
            partyArray = new String[n];
            voteArray = new int[n];

            for (x = 0; x < n; x++)
            {
                nameArray[x] = Console.ReadLine();
                partyArray[x] = Console.ReadLine();
                voteArray[x] = 0;
            }

            n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                name = Console.ReadLine();
                for (x = 0; x < n; x++)
                    if (nameArray[x] == name)
                        break;
                if (x < n)
                    voteArray[x]++;
            }


            maxIndex = 0;
            maxVote = voteArray[0];
            name = partyArray[0];

            for (x = 1; x < n; x++)
            {
                if (voteArray[x] > voteArray[maxIndex])
                {
                    maxIndex = x;
                    maxVote = voteArray[x];
                    name = partyArray[x];
                }
            }



            // n1 now will be used for finding frequency 
            // of highest vote count    
            n1 = 0;
            for (x = 0; x < n; x++)
                if (voteArray[x] == maxVote)
                    n1++;
            if (n1 == 1) // clean win by the candidate 
                Console.WriteLine(name);
            else //there are more than 1 candidate having highest votes 
                Console.WriteLine("tie");
        }
    }
}
