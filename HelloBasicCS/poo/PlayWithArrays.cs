using System;
namespace HelloBasicCS.poo
{
    public class PlayWithArrays
    {
        public PlayWithArrays()
        {
        }

        public void Play()
        {
            //must specify the size 
            int[] evenNums = new int[5];

            //number of elements must be equal to the specified size 
            int[] evenNums2 = new int[2] { 2, 4 };

            //cannot use var with array initializer
            // var evenNums = { 2, 4, 6, 8, 10 }; // Not compile    
            var evenNums3 = new int []{ 2, 4, 6, 8, 10 };

            int[] ints = { 1, 2, 3 };

            // Loops
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            foreach(var e in ints)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("LINQ Array");
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            Array.Sort(nums); // sorts array 
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            Array.BinarySearch(nums, 5);// binary search 
        }

        public void PlayWithMultiDimension()
        {
            // Should have the same dimension
            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            // or 
            int[,] arr2dOther = {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                };
        }

        public void PlayWithJaggedArray()
        {
            // different dimension
            int[][] jArray = new int[][]{
                new int[3]{1, 2, 3},
                new int[4]{4, 5, 6, 7}
            };

            Console.WriteLine("Jagged Array");
            Console.WriteLine(jArray[0][0]); //returns 1
            Console.WriteLine(jArray[0][1]); //returns 2
            Array.ForEach(jArray, e => Console.WriteLine(e[0])); // Returns 1, 4
            Array.ForEach(jArray, e =>
            {
                var joined = String.Join(",", e);
                Console.WriteLine(joined);

            });
            }
    }
}
