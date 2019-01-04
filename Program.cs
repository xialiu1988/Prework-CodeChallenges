using System;

namespace Prework_CodeChallenges
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr=new int[]{1,3,3,4,6};
           
            Console.WriteLine("please select number from 1,3,3,4,6");
            int a=Int32.Parse(Console.ReadLine());
             arraymaxresult(arr,a);
        }
    public static void arraymaxresult(int[] arr,int a){
        int score=0;
        for(int i=0;i<arr.Length;i++){
            if(a==arr[i])
                score+=arr[i];
        }
        Console.WriteLine($"your score is {score}");
     }
    }
}
