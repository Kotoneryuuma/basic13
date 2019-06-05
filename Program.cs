using System;
using System.Collections.Generic;

namespace jthird
{
    class Program
    {
        public static void ito225()
        {
            for(int i = 0; i < 256; i++){
                System.Console.WriteLine(i);
            }
        }
        public static void ito225odd()
        {
            for(int i = 0; i < 256; i+=2){
                System.Console.WriteLine(i);
            }
        }

        public static void ito225sum()
        {
            int sum = 0;
            for(int i = 0; i < 256; i++){
                sum += i;
            }
            System.Console.WriteLine(sum);
        }

        public static void thoarr(int[] numbers)
        {
            double sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            double ave = sum /numbers.Length;
            System.Console.WriteLine(ave);
        }
        // int[] arr = {1,2,3,4,12,6};
        //     thoarr(arr);

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++){
                if(max < numbers[i]){
                    max = numbers[i];
                }
            }
            return max;
        }
        // int[] arr = {1,2,3,4,12,6};   
        //     System.Console.WriteLine(FindMax(arr));;


        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            int ave = sum / numbers.Length;  
            return ave;
        }
        // int[] arr = {1,2,3,4,12,6};   
            // System.Console.WriteLine(Sum(arr));;

        
        public static double Average(int[] number)
        {
            double sum = 0;
            for(int i = 0; i < number.Length; i++){
                sum += number[i];
            }
            double ave = sum /number.Length;
            return ave;
        }

        public static void OddArray(int[] number)
        {
            for(int i = 0; i < number.Length; i++){
                if(i % 2 != 0){
                    System.Console.WriteLine(number[i]);
                }
            }
        }
        // int[] arr = {1,2,3,4,12,6};    
        //     OddArray(arr);


        public static void GreaterThanY(int[] numbers, int y)
        {
            int min = y;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > min){
                    System.Console.WriteLine(numbers[i]);
                }
            }

        }
        // int[] arr = {1,2,3,4,12,6};
        //     int y = 3;    
        //     GreaterThanY(arr,y);

        public static void SquareVal(int[] number)
        {
            for(int i = 0; i < number.Length; i++){
               System.Console.WriteLine(i*i);
            }
        }
    // int[] arr = {1,2,3,4,12,6};  
    //         SquareVal(arr);

         public static void Avoidnega(int[] number)
        {
            for(int i = 0; i < number.Length; i++){
                if(number[i] < 0){
                    number[i] = 0;
                }
                System.Console.WriteLine(number[i]);
            }
        }
        // int[] arr = {1,2,-2,-3,12,6};  
        //     Avoidnega(arr);

        public static void maxminave(int[] number)
        {
            int min = number[0];
            int max = number[0];
            int sum = 0;
            for(int i = 0; i < number.Length; i++){
                if(min > number[i]){
                    min = number[i];
                }
                if(max < number[i]){
                    max = number[i];
                }
                sum += number[i];
            }
            int ave = sum/ number.Length;
            // System.Console.WriteLine(min + max + ave);
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(ave);
        }
        // int[] arr = {1,2,-2,-3,12,6,37};  
        //     maxminave(arr);

        public static void ShiftValues(int[] numbers)
        {
            int temp = numbers[0];
            numbers[0] = numbers[numbers.Length-1];
            numbers[numbers.Length-1] = temp;
            for(int i = 0; i < numbers.Length; i++){
                System.Console.WriteLine(numbers[i]);
            }

        }
        //  int[] arr = {1,2,-2,-3,12,6,37};  
        //     ShiftValues(arr);

        public static object[] NumToString(int[] numbers){
            List<object> newList = new List<object>();
            foreach　(var num in numbers){
                if(num<0){
                    newList.Add("Dojo");
                }
                else{
                    newList.Add(num);
                }
            }
            return newList.ToArray();
        }
        

        static void Main(string[] args)
        {
           int[] arr = {1,2,-3,-2,12,6};    
           System.Console.Write(NumToString(arr)[3]);
        }

        
    }
}


// 1, 2
// public static int ito20()
//         {
//             int sum = 0;
//             for(int i = 0; i < 256; i++){
//                 sum += i;
//             }
//             return sum;
//         }
//         static void Main(string[] args)
//         {
//             int[] arr = {1,2,3,4,12,6};
//             System.Console.WriteLine(ito20());
//         }





// public static double Average(int[] number)
//         {
//             double sum = 0;
//             for(int i = 0; i < number.Length; i++){
//                 sum += number[i];
//             }
//             double ave = sum /number.Length;
//             return ave;
//         }
//         static void Main(string[] args)
//         {
//             int[] arr = {1,2,3,4,12,6};
//             System.Console.WriteLine(Average(arr));
//         }