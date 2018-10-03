using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversideTrainingP2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void findLarge()
            {
                int i = 0;
                int large = 0;
                //array declaration
                int[] arr = new int[5];

                //reading array elements 
                Console.WriteLine("Enter array elements : ");
                for (i = 0; i < arr.Length; i++)
                {
                    Console.Write("Element[" + (i + 1) + "]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                //assigning first element to the array
                large = arr[0];
                //loop to compare value of large with other elements
                for (i = 1; i < arr.Length; i++)
                {
                    //if large is smaller than other element
                    //assig that element to the large
                    if (large < arr[i])
                        large = arr[i];
                }
                //finally, we will have largest element, printing here
                Console.WriteLine("Largest element in array : " + large);
            }

            
                static void Main(string[] args)
                {
                    int n, i, j = 0, largest, secondLargest;
                    int[] arr1 = new int[50];

                    Console.Write("\n\nFind the second largest element in an array :\n");
                    Console.Write("-----------------------------------------\n");

                    Console.Write("Input the size of array : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    /* Stored values into the array*/
                    Console.Write("Input {0} elements in the array :\n", n);
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("element - {0} : ", i);
                        arr1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    /* find location of the largest element in the array */
                    largest = 0;

                    for (i = 0; i < n; i++)
                    {
                        if (largest < arr1[i])
                        {
                            largest = arr1[i];
                            j = i;
                        }
                    }
                    /* ignore the largest element and find the 2nd largest element in the array */
                    secondLargest = 0;
                    for (i = 0; i < n; i++)
                    {
                        if (i == j)
                        {
                            i++;  /* ignoring the largest element */
                            i--;
                        }
                        else
                        {
                            if (secondLargest < arr1[i])
                            {
                                secondLargest = arr1[i];
                            }
                        }
                    }

                    Console.Write("The Second largest element in the array is :  {0} \n\n", secondLargest);

                    Console.ReadKey();
                }


            static void findPresent()
          {
            string[] printer = { "jupiter", "neptune", "pangea", "mercury", "sonic" };
             if(printer.Contains("jupiter"))
               {
               Console.WriteLine("BLAH BLAH CODE TO ADD PRINTER VIA WINDOWS EXEC");
               }






                static void FindNumberOfOcuurence()
            {
    int[] numbers = new int[SIZE] { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };
    string[] letters = new string[SIZE] { "m", "m", "s", "m", "s", "s", "s", "m", "s", "s", "s", "s" };
    int[] values = new int[SIZE] { 15, 22, 67, 45, 12, 21, 24, 51, 90, 60, 50, 44 };
    string[] status = new string[SIZE] { "f", "m", "f", "a", "m", "f", "f", "f", "m", "f", "m", "f" };

    // Set the size of Count to maximum value in numbers + 1
    int[] Count = new int[9 + 1];
    int x = 0;
    int i = 0;

    for (i = 0; i < SIZE - 1; i++)
    {
        if (numbers[i] > 0 && numbers[i] < SIZE)
        {
            // Use value from numbers as the index for Count and increment the count
            Count[numbers[i]]++;
        }
    }

    for (i = 0; i < Count.Length; i++)
    {
        // Check all values in Count, printing the ones where the count is 4
        if (Count[i] == 4)
            Console.WriteLine("{0}", i);
    }




                    static void findMaximumOccurence()
{
    List<String> list = Arrays.asList("1", "1", "1", "1", "1", "1", "5", "5", "12", "12", "12", "12", "12", "12", "12", "12", "12", "12", "8");
    int max = 0;
    int curr = 0;
    String currKey = null;
    Set<String> unique = new HashSet<String>(list);

    for (String key : unique)
    {
        curr = Collections.frequency(list, key);

        if (max < curr)
        {
            max = curr;
            currKey = key;
        }
    }

    Console.WriteLine("The number " + currKey + " happens " + max + " times");
}

static int countSpacesInaString()
{
    public static int SpaceCount(string str)
    {
        int spcctr = 0;
        string str1;
        for (int i = 0; i < str.Length; i++)
        {
            str1 = str.Substring(i, 1);
            if (str1 == " ")
                spcctr++;
        }
        return spcctr;
    }
    public static void Main()
    {
        string str2;
        Console.Write("\n\nFunction to count number of spaces in a string :\n");
        Console.Write("----------------------------------------------------\n");
        Console.Write("Please input a string : ");
        str2 = Console.ReadLine();
        Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
    }
}


        static void ascendingSort()
{
    int[] arr = new int[5] { 5, 6, 2, 4, 1 };

    for (int i = 0; i <= arr.Length; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            int temp = arr[i + 1];
            arr[i] = arr[i + 1];
            arr[i] = temp;
        }

        Console.Write(arr[i]);
    }
}

        static void finfEvenNo()
{
    int[] arr = new int[5] { 5, 6, 2, 4, 1 };

    for (int i = 0; i <= arr.Length; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            int temp = arr[i + 1];
            arr[i] = arr[i + 1];
            arr[i] = temp;
        }

        Console.Write(arr[i]);
    }
}


        static void fibinchiSeq()
{

    int i, count, f1 = 0, f2 = 1, f3 = 0;
    Console.Write("Enter the Limit : ");
    count = int.Parse(Console.ReadLine());
    Console.WriteLine(f1);
    Console.WriteLine(f2);
    for (i = 0; i <= count; i++)
    {
        f3 = f1 + f2;
        Console.WriteLine(f3);
        f1 = f2;
        f2 = f3;
    }
    Console.ReadLine();
}



        static void RevesrseString()
{
    string Str, reversestring = "";
    int Length;
    Console.Write("Enter A String : ");
    Str = Console.ReadLine();
    Length = Str.Length - 1;
    while (Length >= 0)
    {
        reversestring = reversestring + Str[Length];
        Length--;
    }
    Console.WriteLine("Reverse  String  Is  {0}", reversestring);
    Console.ReadLine();
}

public int convertToInt()
{
    int i = 0;
    string s = "123";
    i = int.Parse(s);
    i = Convert.ToInt32(s);
}


public int maximumDiff()
{
    int maxDiff(int arr[], int arr_size)
    {
        int max_diff = arr[1] - arr[0];
        for (int i = 0; i < arr_size; i++)
        {
            for (int j = i + 1; j < arr_size; j++)
            {
                if (arr[j] - arr[i] > max_diff)
                    max_diff = arr[j] - arr[i];
            }
        }
        return max_diff;
    }
}


        static void numberOfCharectersInNumber()
{
    long blah = 20948230498204;
    Console.WriteLine(blah.ToString().Length);
}


public int sumOfDigitsInNum()
{
    sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
}

        static void sumOddNumbers()
{
    int k;
    int min;
    int max;
    int odd = 0;

    Console.WriteLine("Enter the value of k: ");
    k = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter minimum integer: ");
    min = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter maximum integer: ");
    max = int.Parse(Console.ReadLine());

    Console.Write("Odd: ");
    for (int x = min; x <= max; x++)
    {
        if (x % 2 != 0)
        {
            Console.Write(x);
            Console.Write(" + ");
            odd += x;
        }
    }

    Console.WriteLine();
    Console.Write("Odd Numbers + K: ");
    Console.WriteLine();
    {
        if (k % 2 != 0)
        {
            Console.Write(k);
            Console.Write(" + ");
            odd += k;
        }
    }

    Console.Write("= ");
    Console.Write(odd + "\n")
}


        static void swapFiestandLast()
{
    int num, last, first, temp, swap, count = 0;

            Console.WriteLine("Enter any number: ");
            Console.WriteLine("%d", num);

    temp = num;
    last = temp % 10;
    count = (int)log10(temp);

    while (temp >= 10)
    {
        temp /= 10;
    }
    first = temp;
    swap = (last * pow(10, count) + first) + (num - (first * pow(10, count) + last));

            Console.WriteLine("Last Digit: %d\n", last);

            Console.WriteLine("First Digit: %d\n", first);

            Console.WriteLine("%d is swapped to %d\n", num, swap);
    //return 0;
}




