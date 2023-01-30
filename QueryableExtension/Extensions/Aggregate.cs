namespace QueryableExtension.Extensions
{
    public static class Aggregate
    {
        public static void GetLongestName(string[] fruits)
        {
            // Determine whether any string in the array is longer than "banana".
            string longestName = fruits.Aggregate("banana",
                    (longest, next) =>
                        next.Length > longest.Length ? next : longest,
                    // Return the final result as an upper case string.
                    fruit => fruit.ToUpper());

            Console.WriteLine(
                "The fruit with the longest name is {0}.",
                longestName);
        }

        public static void GetEvenNumber(int[] numbers)
        {
            int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };

            // Count the even numbers in the array, using a seed value of 0.
            int numEven = ints.Aggregate(0, (total, next) =>
                                                next % 2 == 0 ? total + 1 : total);

            Console.WriteLine("The number of even integers is: {0}", numEven);

            // This code produces the following output:
            //
            // The number of even integers is: 6
        }
        public static void Reversing(string words = "the quick brown fox jumps over the lazy dog")
        {
            // Split the string into individual words.
            string[] word = words.Split(' ');

            // Prepend each word to the beginning of the
            // new sentence to reverse the word order.
            string reversed = word.Aggregate((workingSentence, next) =>
                                                  next + " " + workingSentence);

            Console.WriteLine(reversed);

            // This code produces the following output:
            //
            // dog lazy the over jumps fox brown quick the
        }


    }

}
