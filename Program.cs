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
             //challenge3
             perfectsequence();
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

  public static void perfectsequence(){
  
Console.WriteLine("please enter how many numbers you want");
int n=Int32.Parse(Console.ReadLine());

int[] newarray=new int[n];
int sum=0;
int product=1;
for(int i=0;i<n;i++){
    Console.WriteLine("please enter{0} element:",i+1);
    newarray[i]=Int32.Parse(Console.ReadLine());
    sum+=newarray[i];
    product*=newarray[i];
}

   if(sum<0){
       Console.WriteLine("Sorry this is not a perfect sequence.");
   }
else if(sum==product){
    Console.WriteLine("Yes,you have a perfect sequence!");
}
 else
            {
                Console.WriteLine("Sorry this is not a perfect sequence.");
            }

  }

    }
}
