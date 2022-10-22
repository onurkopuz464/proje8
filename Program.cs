using System;

namespace c
{
    class Program
    {
        public static void staircase(string[] people)
    {
        foreach (var item in people)
        {
            Console.WriteLine(item);
        }
        
    }

        static void Main(string[] args)
        {
           string[] peopleSend = {"ali","veli","hüsnü"};
           staircase(peopleSend);
         
        

        }
        
        
      
    }
    
}