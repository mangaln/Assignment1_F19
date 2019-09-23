using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1, z = 22; //x and z is number range to be given, y is check for self division check
            printSelfDividingNumbers(x,z);
            int n2 = 5; // n2=number of elements to be printed from series 1 2 2 3 3 3.....
            Console.WriteLine("\nPrint series output");
            printSeries(n2);
            int n3 = 5;// n3= number of lines with which triangle should be printed
            Console.WriteLine("\nPrint triangle output");
            printTriangle(n3);
            int[] J = new int[] { 1, 3 }; //J= jewels 
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };//Stones we have
            Console.WriteLine("\nPrint Jewels in Stone output");
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine("I have " + r4 + " jewels");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nPrint Greatest common subarray output");
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            for (int r = 0; r < r5.Length; r++)
                Console.Write(r5[r] + " ");
        }
        public static void printSelfDividingNumbers(int x,int z)
        {
            try {  
                int y=0; //y= counter checking if number is divisible with all digits or not
            for (int i = x; i <= z; i++)
            {                     
                        y = GenerateCounter(y,i);//Generating counter y, based on condition of number divisibility by digits
                    
                    if (y == 0)
                    {
                        Console.WriteLine("The self-dividing number:"+i);
                    }
                    else
                    {
                        y = 0;
                        Console.WriteLine("The non self-dividing number:"+i);
                    }
                }
                }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }
        public static int GenerateCounter(int y,int i)
        {
            int c,d, e;
            d = i;
            while (d != 0) //while number is not 0
            {
                if (d % 10 != 0) //if some digit of number is zero
                {
                    e = d % 10;
                    d = d / 10;
                    c = i % e;
                    if (c != 0) //if number is not divisible with all the digits
                    {
                        y++;
                    }

                }
                else // if number is divisible by 10                        

                {
                    y = 1;
                    break;
                }
            }
            return y;
        }
        public static void printSeries(int n)
        {
            int i = 1, j;//i is number to print and j is counter
            try
            {
                while (n != 0 && n > 0)//To check that only n numbers should print
                {
                    j = i;
                    while (j <= i && j != 0)//To check that i should print i times
                    {
                        n--;
                        if (n >= 0)//Check that an extra number should not print
                        {
                            Console.Write(i + " ");
                        }
                        j--;
                    }
                    i++;
                }
                Console.Write("\n");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }
        public static void printTriangle(int n)
        {
            try
            {
                for (int i = n; i >= 1; i--)
                {
                    for (int j = 1; j <= n - i; j++)//To create a space before printing a new line
                    {
                        Console.Write(" ");
                    }
                    for (int j = (2 * i) - 1; j >= 1; j--)//To print * in every line
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        public static int numJewelsInStones(int[] J, int[] S)
        {
            int k = 0;
            try
            {
                for (int i = 0; i < S.Length; i++)
                {
                    for (int j = 0; j < J.Length; j++)
                    {
                        if (S[i] == J[j])//check which stone is a jewel
                        {
                            k++;

                        }

                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return k;
        }
        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {

            int i, max = 0, end = 0, j = 0, len = 0;
            try
            {
                for (i = 0; i < a.Length; i++)
                {
                    for (; j < b.Length; j++)
                    {
                        if (b[j] == a[i])
                        {
                            len++;//increase length so that we would know contiguous equal elements
                            j++;
                            break;
                        }
                        else
                        {
                            if (len >= max)//compare so that we can get the max length of contiguous commomn array
                            {
                                max = len;
                                len = 0;
                                end = i - 1;
                            }
                            if (a[i] < b[j])//As the array is sorted we can compare and lements are not equal , we can compare the next element
                            {
                                len = 0;
                                break;
                            }

                        }

                    }
                }
                if (len >= max)//as we are copying the value outside the loop, needs to get max, len and end value
                {
                    max = len;
                    len = 0;
                    end = i - 1;
                }

                int[] c = new int[max]; j = 0;
                for (i = end - max + 1; i <= end; i++, j++)
                {
                    c[j] = a[i];
                }
                return c;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            return null;
        }
    }
}
