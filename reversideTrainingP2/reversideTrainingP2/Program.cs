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
            findLarge();
            findSecondLarge();
            findPresent();


            void findLarge()
            {
                int[] arr1 = new int[100];
                int i, mx, mn, n;


                Console.Write("\n\nFind maximum and minimum element in an array :\n");
                Console.Write("--------------------------------------------------\n");

                Console.Write("Input the number of elements to be stored in the array :");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }


                mx = arr1[0];
                mn = arr1[0];

                for (i = 1; i < n; i++)
                {
                    if (arr1[i] > mx)
                    {
                        mx = arr1[i];
                    }


                    if (arr1[i] < mn)
                    {
                        mn = arr1[i];
                    }
                }
                Console.Write("Maximum element is : {0}\n", mx);
                Console.Write("Minimum element is : {0}\n\n", mn);
                Console.ReadLine();
            }

        }


        static void findSecondLarge()
        {
            int n, i, j = 0, largest, secondLargest;
            int[] arr1 = new int[50];

            Console.Write("\n\nFind the second largest element in an array :\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            largest = 0;

            for (i = 0; i < n; i++)
            {
                if (largest < arr1[i])
                {
                    largest = arr1[i];
                    j = i;
                }
            }

            secondLargest = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;
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
            string[] array1 = { "cat", "dogs", "donkey", "camel" };
            string v1 = Array.Find(array1,
                element => element.StartsWith("cam", StringComparison.Ordinal));
            string v2 = Array.Find(array1,
                element => element.Length == 3);
            Console.WriteLine("The Elemnt that Starts with 'Cam' is : " + v1);
            Console.WriteLine("3 Letter word in the Array is : " + v2);
            Console.ReadLine();
        }







        void FindNumberOfOcuurence()
        {
            int[] array = new int[6] { 3, 4, 3, 5, 5, 3 };
            int count = 1, tempCount;
            int frequentNumber = array[0];
            int tempNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempNumber == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", frequentNumber, count);
            Console.ReadKey();
        }




        static void countSpacesInString()
        {
            string Paragraph = "";
            ;
            int i = 0, b = 0;
            int Count2 = 1;
            for (i = 0; i < Paragraph.Length; i++)
            {
                if (Paragraph[i] == ' ')
                {
                    for (b = i; b < Paragraph.Length; b++)
                    {
                        if (Paragraph[b] != ' ' && Paragraph[b] != '\t')
                        {
                            Count2++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Total Word = {0} .", Count2);

        }


        public static void countNoWords()
        {
            string str;
            int i, wrd, l;

            Console.Write("\n\nCount the total number of words in a string :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Total number of words in the string is : {0}\n", wrd);
        }
        public static void replaceStringWithUnderscore()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string replacedStr = null;

            // This loop will repalce all repeat black space in single space
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (!(Convert.ToString(str[i]) == " " &&
                    Convert.ToString(str[i + 1]) == " "))
                {
                    replacedStr = replacedStr + str[i];
                }
            }
            replacedStr = replacedStr + str[str.Length - 1]; // Append last character
            replacedStr = replacedStr.Replace(" ", "_");
            Console.WriteLine(replacedStr);
            Console.ReadLine();
        }






        public static void ascendingSort()
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

        public static void finfEvenNo()
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


        public void convertToInt()
        {
            int i = 0;
            string s = "123";
            i = int.Parse(s);
            i = Convert.ToInt32(s);
        }


        public void maximumDiff()
        {
            var testList = new List<int> { 2223, 2229, 2235, 2240 };
            int max = Int32.MinValue;
            int delta = 0;

            for (int i = 1; i < testList.Count; i++)
            {
                delta = testList[i] - testList[i - 1];
                if (delta > max) max = delta;
            }

            Console.WriteLine("The maximum difference is {0}", max);
            Console.ReadKey();
        }


        static void numberOfCharectersInNumber()
        {
            long blah = 20948230498204;
            Console.WriteLine(blah.ToString().Length);
        }


        public void sumOfDigitsInNum()
        {
            int num, sum = 0, r;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();
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
            Console.Write(odd + "\n");
        }


        static void swapFiestandLast()
        {
            Console.WriteLine("Please enter a number (or 'X' to exit): ");
            string line;
            while ((line = Console.ReadLine()) != "X")
            {
                int number = 0;
                if (!int.TryParse(line, out number))
                    Console.WriteLine("Please enter a valid number");

                //swap the first and last digit if the entered number has more than 1 digit...
                if (line.Length > 1)
                {
                    char[] digits = line.ToCharArray();
                    char firstDigit = digits[0];
                    digits[0] = digits[digits.Length - 1];
                    digits[digits.Length - 1] = firstDigit;
                    Console.WriteLine(new string(digits));
                }

            }
        }
        public void checkIfVowel()
        {
            string b;
            int vowelsInString = 0;
            int consonants = 0;
            int lengthOfString;
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            string ourString;
            Console.WriteLine("Enter a sentence or a word");
            ourString = Console.ReadLine();
            ourString = ourString.ToLower();

            foreach (char character in ourString)
            {
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (vowels[i] == character)
                    {
                        vowelsInString++;
                    }
                }
            }
            lengthOfString = ourString.Count(c => !char.IsWhiteSpace(c)); //gets the length of the string without any whitespaces
            consonants = lengthOfString - vowelsInString; //Well, you get the idea.
            Console.WriteLine();
            Console.WriteLine("Vowels in our string: " + vowelsInString);
            Console.WriteLine("Consonants in our string " + consonants);
            Console.ReadKey();

        }
        public void ReverseNumber()
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}

   


