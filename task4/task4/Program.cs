using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {





            //Console.WriteLine(InnerTrim("salam,     Dunya,"));




            //Console.WriteLine(info1("Salam dunya"));

            // Findinfo();

            // Console.WriteLine(findupper("Code Academy"));

            int[] array = {14,23,55,66};
            int[] num = {68};
            Elements(ref array,68);
            




        }

        // 1-ci
        public static string InnerTrim(string input)
        {
            return input.Trim().Replace("    ", string.Empty);
        }

        // 2-ci
        public static bool info1(string sentence)
        {
            bool hasdigit = false;
            bool check = false;
            bool islower = false;

            for (int i = 0; i < sentence.Length; i++)
            {

                if (char.IsDigit(sentence[i]))
                {
                    hasdigit = true;
                }

                if (char.IsUpper(sentence[i]))
                {
                    check = true;
                }

                if (char.IsLower(sentence[i]))
                {
                    islower = true;
                }

            }

            bool result = check && hasdigit && islower;

            return result;

        }

        // 3-cu

        public static void Findinfo()
        {
            string phrase = "salam dunya";

            string[] words = phrase.Split(' ');


            foreach (var word in words)
            {
                Console.WriteLine(words[0]);
                break;
            }

        }

        // 4-cu

        public static bool findupper(string sentence)
        {
            bool isupperr = false;
            bool checkk = false;

            string[] newsentence = sentence.Split();

            string firstsentence = newsentence[0];
            string seconsentence = newsentence[1];

            foreach (var item in newsentence)
            {
                if (firstsentence[0]==char.ToUpper(firstsentence[0]))
                {
                    isupperr = true;
                }
                if (seconsentence[0]==char.ToUpper(seconsentence[0]))
                {
                    checkk= true;

                }

            }

            bool result = isupperr&&checkk;
            return result;

        }

        // 5-ci

        static void Elements(ref int[] array, int num)
        {
            int[] arr = new int[array.Length + 1];
            arr[array.Length] = num;

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            array = arr;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


    }









}

