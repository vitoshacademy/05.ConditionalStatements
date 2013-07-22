using System;


class SubSet
{
    static void Main()
    {
        int[] intArray = new int[5];

        for (int i = 0; i < 5; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int subsetCount = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                sum = intArray[i] + intArray[j];
                if (sum == 0)
                {
                    subsetCount++;
                    Console.WriteLine("{0} + {1} = {2}", i, j, sum);
                }
                for (int k = j + 1; k < 5; k++)
                {
                    sum = sum + intArray[k];
                    if (sum == 0)
                    {
                        subsetCount++;
                        Console.WriteLine("{0} + {1} + {2} = {3}", i, j, k, sum);
                    }
                    for (int l = k + 1; l < 5; l++)
                    {
                        sum = sum + intArray[l];
                        if (sum == 0)
                        {
                            subsetCount++;
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", i, j, k, l, sum);
                        }
                        for (int m = l + 1; m < 5; m++)
                        {
                            sum = sum + intArray[m];
                            if (sum == 0)
                            {
                                subsetCount++;
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", i, j, k, l, m, sum);
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("There are {0} sums of subsets that are equal to Zero!", subsetCount);

    }
}
