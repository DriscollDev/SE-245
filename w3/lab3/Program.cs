//Convert week 2 lab to utilize Methods (Void / Return / By Ref)
namespace Week3_Lab {
    class Program {
        static string letterGrade(Int32 avg){
            if(avg >= 90){
                return "A";
            }
            else if (avg >= 80){
                return "B";
            }
            else if(avg >= 70){
                return "C";
            }
            else if(avg >= 60){
                return "D";
            }
            else{
                return "F";
            }
        }


        static void Main(string[] args){
            Console.Write ("Please enter the number of students you are averaging: ");
            Int32 students = Int32.Parse(Console.ReadLine ());
            string[] names = new string[students];
            Int32[,] grades = new int[students, 5];
            for (int i = 0; i < students; i++){
                Console.WriteLine("------------------------------------------");
                Console.Write($"Enter the name of student {i+1}: ");
                names[i] = Console.ReadLine();
                for (int j = 0; j < 5; j++){
                    Console.Write($"Enter the grade for lab {j+1}: ");
                    grades[i,j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < students; i++){
                Int32 total = 0;
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Student {i+1}: {names[i]}");
                for (int j = 0; j < 5; j++)
                {
                    total += grades[i,j];   
                }
                Int32 avg = total/5;
                string lGrade = letterGrade(avg);
                Console.WriteLine($"Average of Labs: {avg}\nLetter Grade: {lGrade}");
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Average for each lab");

            for (int i = 0; i < 5; i++)
            {
                Int32 total = 0;
                for (int j = 0; j < students; j++)
                {
                    total += grades[j,i];
                }
                Int32 avg = total/students;
                Console.WriteLine($"Lab {i+1} Average: {avg} : {letterGrade(avg)}");
            }
        }
    }
}