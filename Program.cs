namespace LongestSubArrayWithSumK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 1, 1, 1, 1, 4, 2, 3 };
            Console.WriteLine("Orignal Array");
            PrintArray(myArray);
            int k = 3;
            Console.WriteLine("Longest Sub Array with Sum " + k);
            Console.WriteLine(LongestSubArray1(myArray,k));

        }

        //optimized
        static int LongestSubArray2(int[] a, int k)
        {


            return k;
        }

        //Brute1
        static int LongestSubArray(int[] a, int k)
        {
            int maxlen = 0;
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i; j < a.Length; j++)
                {
                    int sum = 0;
                    for (int l = i; l <= j; l++)
                        sum += a[l];
                    
                    if(sum == k)
                        maxlen = Math.Max(j-i+1, maxlen);
                }
            }
            return maxlen;

        }

        //brute 2
        static int LongestSubArray1(int[] a, int k)
        {
            int maxlen = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < a.Length; j++)
                {
                    sum += a[j];

                    if (sum == k)
                        maxlen = Math.Max(j - i + 1, maxlen);
                }
            }
            return maxlen;

        }

        static void PrintArray(int[] a)
        {
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}