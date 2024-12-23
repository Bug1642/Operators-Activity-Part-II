using System;
namespace RelationalOperatorsExercise
{
    public class StudentInput
    {
        public bool studentCanWatch(int age, bool withParent)
        {
            bool canWatch;
            if (age >=18 || (age < 18 && withParent))
                canWatch =true; 
            else
                canWatch=false;
            return canWatch;
        }
    }
    class Program{
        static void Main(string [] args ){
            StudentInput watch = new StudentInput(); 
            Console.WriteLine(watch.studentCanWatch(17,false));
            Console.WriteLine(watch.studentCanWatch(17,true));
            Console.WriteLine(watch.studentCanWatch(18,false));
            Console.WriteLine(watch.studentCanWatch(18,true));
        }
    }
}