using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Sequence
    {
        private int lenghtarr;
        public int LenghrArr { get; set; }
        
        
            
            

        
        public int[] RandomArr (int amount)
        {
            lenghtarr = amount;
            var arr = new int[amount];
            Random rand = new Random();
            for (int i = 0; i < amount; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            return arr;
        }
        

        public int OutFirstPosition(int n) 
        {
            int [] arr = RandomArr(LenghrArr);
            var arrsum = new int[lenghtarr - 4];            
            int lenght = arr.Length;
            
            for (int i = 0; i < lenght - 4; i++)
            {
                int index2 = 0;
                index2++;
                
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += arr[index2];
                }
                
                arrsum[index2] = sum; //attention!!! 
                
            }
            int index = System.Array.IndexOf(arr, arr.Max());
            if (n > arr.Length)
                return -1;
            else
                return index;
        }

        public Sequence (int a)
        {
            LenghrArr = a;
            
        }


    }
}

