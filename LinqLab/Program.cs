namespace LinqLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lab for nums
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            int lowest = nums.Min();
            Console.WriteLine(lowest);
            Console.WriteLine("");
            int highest = nums.Max();
            Console.WriteLine(highest);
            Console.WriteLine("");
            int maxUnderTenThousand = nums.Where(n => n < 10000).Max();
            Console.WriteLine(maxUnderTenThousand);
            Console.WriteLine("");
            
            List<int> intsBetween10And100 = nums.Where(n => n > 10 && n < 100).ToList();
            PrintList(intsBetween10And100);
            Console.WriteLine();

            List<int> intsBetweenLargeNums = nums.Where(n => n > 100000 && n < 999999).ToList();
            PrintList(intsBetweenLargeNums);
            Console.WriteLine("");

            int allEven = nums.Where(n => n % 2 == 0).Count();
            Console.WriteLine(allEven);
            Console.WriteLine("");

            List<int> mostToLeast = nums.OrderByDescending(n => n).ToList();
            PrintList(mostToLeast);
            Console.WriteLine("");

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            List<Student> legalDrinkingAge = students.Where(student => student.Age >= 21).ToList();
            PrintStudents(legalDrinkingAge);
            Console.WriteLine("");
            
            int oldest = students.Max(n => n.Age);
            Console.WriteLine($"The oldest student is {oldest}");
            Console.WriteLine("");
            
            int youngest = students.Min(n => n.Age);
            Console.WriteLine($"The youngest student is {youngest}");
            Console.WriteLine("");
           
            List<Student> oldestUnder25 = students.Where(n => n.Age < 25).ToList();
            int oldUnder25 = oldestUnder25.Max(n => n.Age);
            Console.WriteLine($"The oldest under 25 is {oldUnder25}");
            Console.WriteLine("");

            List<Student> over21Even = students.Where(student => student.Age > 21 && student.Age % 2 == 0).ToList();
            PrintStudents(over21Even);
            Console.WriteLine("");

            List<Student> teenagers = students.Where(student => student.Age >= 13 && student.Age <= 19).ToList();
            PrintStudents(teenagers);
            Console.WriteLine("");

            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            List<Student> startVowel = students.Where(student => vowels.Contains(student.Name[0])).ToList();
            PrintStudents(startVowel);
            Console.WriteLine("");

            List<Student> youngToOld = students.OrderBy(n => n.Age).ToList();
            PrintStudents(youngToOld);
            Console.WriteLine("");

        }

        //print out student info
        public static void PrintStudents(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }
        //to print out int lists
        public static void PrintList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }
        //to print out string lists
        public static void PrintList(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                string s = input[i];
                Console.WriteLine($"{i}: {s}");
            }
        }
    }
}