#region task1
//Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.If target is not found in the array, return [-1, -1]
//class SearchingTarget
//{
//    public static int search(int[] arr, int Number, int target)
//    {
//        for (int i = 0; i < Number; i++)
//        {
//            if (arr[i] == target)
//                return i;
//        }
//        return -1;
//    }
//    static void Main()
//    {
//        int[] arr = { 1, 5, 7, 8, 9, 6 };
//        int target = 5;
//        int ResultOfSearching=search(arr,arr.Length,target);
//        if (ResultOfSearching == -1)
//        {
//            Console.WriteLine("Your target doesn't exist in the array: " );
//        }
//        else
//        {
//            Console.WriteLine("Your target  exists in the array: "+ ResultOfSearching);
//        }


//    }




//}
#endregion
#region task2
//Implement pow(x, n), which calculates x raised to the power n (i.e., xn).
//using System;
//public class Solution {
//    static double Power(double number, int power)
//    {
//        double result = 1;
//        if (power < 0)
//        {
//            power = -power;
//            number = 1 / number;
//        }
//        while (power != 0)
//        {
//            if ((power & 1) == 1)
//            {  
//                result *= number;
//            }
//            number *= number;  
//            power >>= 1;  
//        }
//        return result;
//    }
//    static void Main(string[] args)
//    {

//        Console.WriteLine("Enter your number: ");
//        double number = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Enter power: ");
//        int power = Convert.ToInt32(Console.ReadLine());


//        double result = Power(number, power);
//        Console.WriteLine("Your result: " + result);

//    }
//}


#endregion