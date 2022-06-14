using System;

namespace Question_2{

    public class Program{
        static void Main(){
            int firstFibonacci=0, secondFibonacci,start=1, end =0, target;
            List<int> fibonacci = new List<int>();
            fibonacci.Add(end);
            fibonacci.Add(start);

            Console.WriteLine("How large are the Fibonacci sequence do you want?");
            secondFibonacci = int.Parse(Console.ReadLine());
            Console.WriteLine("FIBONACCI SEQUENCE!!\n");

            for(int i=2;i<secondFibonacci;++i) {
                 firstFibonacci = start + end;
                 fibonacci.Add(firstFibonacci);
                 end = start;
                 start = firstFibonacci;
            }    
            Console.WriteLine("Type one number:");
            target = int.Parse(Console.ReadLine());

            if(fibonacci.Contains(target)){
                Console.WriteLine("Your number is in Fibonacci sequence");
            }
            else{
                Console.WriteLine("Your number is not in fibonacci sequence");
            }
        }
    }
}

