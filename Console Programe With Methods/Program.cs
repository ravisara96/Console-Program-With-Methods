/*
 
Author: Sachiwa Irugalbandara
Data:09/24/2020
Comments: Using methods in the C# programe to get an output from the input that user types from his/her name.
*/

using System;

namespace Console_Programe_With_Methods
{
   public class Program
    {
        string name;
        public void GetName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0} Go Bucs!", name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetName();
            Console.ReadLine();

            Console.WriteLine("Please enter your grade between 50 and 100 ");
            
          
            /* 
             Using the catch block to validate the user input
            */
            try
            {
                // This variable will collect the input
                string input = Console.ReadLine();
                // This varibale will be used to calculate the grade
                int grade = int.Parse(input);
                //This IF statement test to see if the user input grade between 
                if ((grade > 49) && (grade <= 100))
                {
                    int get_max_grade = Max_Grade(grade);
                    Recommend_Work(get_max_grade);

                    //user will get a message
                    Console.WriteLine("Great Work! Work Harder to achieve your goals");
                    // This will exit from the window after the answer
                    Console.WriteLine("Press any key to exit the window");
                    //This will exit from the window after pressing any button
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter only your name and grade!");
                    Console.WriteLine("Press any key to exit the window");
                    Console.ReadKey(true);
                }
            }// End of try
            catch
            {
                Console.WriteLine("Please enter your name and grade and try again");
                Console.WriteLine("Press any to close the window ");
                Console.ReadKey(true);
            
            }// End of catch               
        }// End of stream

        private static int Max_Grade(int get_grade)
        {
            // The formula for max grade
            int calculate_max_grade = 200 - get_grade;
            Console.WriteLine("");
            Console.WriteLine("Based on the amount you entered!" + get_grade);
            Console.WriteLine("Your maximum grade will be " + calculate_max_grade);

            return calculate_max_grade;
        }// End of max grade


        /*
         This static shows how the recommended work
        */

        private static void Recommend_Work(int get_grade)
        {
            // Calculate the recommended lower grade
            double lower_recommend_grade = get_grade / 2;
            // Calculate the recommended upper grade
            double upper_recommend_grade = get_grade * 2;
            Console.WriteLine("");
            Console.WriteLine("Your target grade between semester is 80 and 300");
            Console.WriteLine("");
            Console.WriteLine("Your recommended lower grade during the semester is " + lower_recommend_grade);
            Console.WriteLine("Your recommended upper grade during the semester is" + upper_recommend_grade);
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the window");
            Console.ReadKey(true);
        }// End of exercise
    }// End of class
}// End of namespace
