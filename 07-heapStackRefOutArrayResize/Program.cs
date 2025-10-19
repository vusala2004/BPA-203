using System;

namespace _07_heapStackRefOutArrayResize
{
   internal class Program
    {
        static void Main(string[] args)
       {
           int[] numbers1 = {1,2,3};//3 ededli massiv yaradiram
           int[] numbers2 = {5,6,7};// basqa 3 ededli massiv yaradiram
           int[] combined=numbers1.Concat(numbers2).ToArray();
           CustomArrResize(ref numbers1, 4);// birinci massive 4 elave
          CustomArrResize(ref numbers2, 8);// ikinci massive 8 elave

       }
        public static void CustomArrResize(ref int[] arr,int num)
       {
           int[] newArr = new int[arr.Length + 1];//1 2 3 0
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i]; }
            newArr[arr.Length] = num;
            arr = newArr;
            
     
            for(int j=0; j < arr.Length; j++)
            {
                newArr[j]=arr[j];
            }
            newArr[arr.Length - 1] = num;
            for (int b=0;b<newArr.Length; b++)
            {
                Console.WriteLine(newArr[b]);
            }
            
        }
        
   }
}
