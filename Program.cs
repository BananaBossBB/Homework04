using System;

public class Program
{
    public static void Main(string[] args)
    {
        int people = 0;
        int max = 0;
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        if(n >= 1 && n <= 10000 && k >= 1 && k<= 100)
        {
            int[] arrPeople = new int[n];
            for(int i = 0;i < n;i++)
            {
                arrPeople[i] = int.Parse(Console.ReadLine());
            }
            if(k > n/2)
            {
                for(int i = 0;i < n;i++)
                {
                    max = max + arrPeople[i];
                }
                Console.WriteLine(max);
            }
            else
            {
                for(int i = k;i < n-k;i++)
                {
                    people = arrPeople[i];

                    for(int j = 1;j < k+1;j++)
                    {
                        people = people + arrPeople[i+j];
                        people = people + arrPeople[i-j];
                    }  
                    if(people > max)
                    {
                        max = people;
                    }    
                }
                Console.WriteLine(max);            
            }
        }
    }
}

