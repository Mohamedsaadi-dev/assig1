using System.Collections;

namespace assig1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            var intRange = new Range<int>(1, 10);
            Console.WriteLine(intRange);
            Console.WriteLine($"Is 5 in range: {intRange.IsInRange(5)}");
            Console.WriteLine($"Is 15 in range: {intRange.IsInRange(15)}");
            Console.WriteLine($"Length of range: {intRange.Length()}");
            var doubleRange = new Range<double>(1.5, 5.5);
            Console.WriteLine(doubleRange);
            Console.WriteLine($"Is 3.0 in range: {doubleRange.IsInRange(3.0)}");
            Console.WriteLine($"Length of range: {doubleRange.Length()}");
            var stringRange = new Range<string>("apple", "orange");
            Console.WriteLine(stringRange);
            Console.WriteLine($"Is 'banana' in range: {stringRange.IsInRange("banana")}");
            #endregion
            #region q2
            ArrayList myList = new ArrayList { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original ArrayList:");
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nReversed ArrayList:");
            foreach (var item in myList)
            {
            
                Console.Write(item + " ");
            }
            #endregion
            #region q3
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = nums.Where(num => num % 2 == 0).ToList();

            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            #endregion
            #region q4
            try
            {
                var fixedList = new FixedSizeList<int>(3); 

                fixedList.Add(10);
                fixedList.Add(20);
                fixedList.Add(30);

                Console.WriteLine("Element at index 1: " + fixedList.Get(1));

                fixedList.Add(40);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var fixedList = new FixedSizeList<int>(3);
                fixedList.Add(10);
                Console.WriteLine(fixedList.Get(5)); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
