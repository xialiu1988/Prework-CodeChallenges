using System;

namespace Prework_CodeChallenges
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //challenge1
            int[] arr=new int[]{1,3,3,4,6};
            Console.WriteLine("please select number from 1,3,3,4,6");
            int a=Int32.Parse(Console.ReadLine());
             arraymaxresult(arr,a);

            //challenge2
             Console.WriteLine("please choose a year you like");
             int b=Int32.Parse(Console.ReadLine());
             leapyearcalculator(b);
        }
    public static void arraymaxresult(int[] arr,int a){
        int score=0;
        for(int i=0;i<arr.Length;i++){
            if(a==arr[i])
                score+=arr[i];
        }
        Console.WriteLine($"your score is {score}");
     }


    public static void leapyearcalculator(int b){

    if(b%400==0){
        Console.WriteLine($"{b} is a Leap Year");
    }
else if(b%100==0){
       Console.WriteLine($"{b} is NOT a Leap Year");
    }
    else if(b%4==0){
        Console.WriteLine($"{b} is a Leap Year");
    }
    else{
        Console.WriteLine($"{b} is NOT a Leap Year");
    }

    }

    }
}
