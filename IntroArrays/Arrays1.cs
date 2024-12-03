namespace Arrays1
{
    internal class Program
    {
        public static void PrintArray(int[] arr)
        {
            foreach (int elem in arr)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
        // 1D arrays
        private static void Main(string[] args)
        {
            // declare and then allocate space
            int[] numbers;
            numbers = new int[10];

            // declare and allocate space in the same time
            float[] fnum = new float[10];

            // declare and initialise 
            int[] num = new int[6] { 33, 22, 66, 88, 2, 9 };
            string[] names = new string[3] { "Matt", "Joanna", "Daniel" };

            // you can omit the size of the array
            int[] nums = new int[] { 1, 2, 3, 4 };

            // you can omit the new operator - if an initialiser is provided
            int[] nums2 = { 1, 2, 3, 4 };
            string[] names2 = { "John", "Robert", "Steve", "Claire" };

            // using var
            var data1 = new int[3];
            var data2 = new int[3] { 1, 2, 3 };
            var data3 = new int[] { 1, 2, 3 };
            var data4 = new[] { 1, 2, 3 };

            //but this one doesn't work
            //var data5 = {1, 2, 3 };

            // empty arrays
            var data6 = new int[0];
            var data7 = new int[] { };

            // Accessing array members

            string[] colours = { "red", "blue", "green" };
            for (int i = 0; i < colours.Length; i++)
            {
                Console.WriteLine($"Colour = {colours[i]}");
            }

            int[] numbers2 = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };

            foreach (int i in numbers2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = 2 * numbers2[i];
            }
            Console.WriteLine("The new values in the array are: ");
            PrintArray(numbers2);

            Console.ReadLine();

            // error if I try this:
            Console.WriteLine(numbers2[9]);

        }

    }

    //what to take from this demo:
    //declaring, initialising the arrays
    //passing through with for and foreach and the difference between them
    //out of range error
    //being able to modify the elements for for, but not with foreach
    //passing the array as parameter in a method

}
