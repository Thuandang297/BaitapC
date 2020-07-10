using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay_thang
{
    class Program
    {
        static void Main(string[] args)
        {
       
            
                Console.Write("Nhap so phan tu cua mang:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap phan tu vao mang:");
                int[] array1 = new int[n];
                //nhap phan tu vao mang
                for (int i = 0; i < n; i++)

                {
                    Console.Write("Phan tu thu [{0}]:", i);
                    array1[i] = int.Parse(Console.ReadLine());
                }
            
            //int sum = 0;
            //foreach(int val in array1)//duyet cac phan tu trong mang
            //{
           
            //    Console.Write( + val+ "\t");
            //    sum += val;
               
            //}
            //Console.Write("\n"+"Tong cua mang tren la:"+sum);
            int max = array1[0];

            //foreach (int val2 in array1)
            //{
            // if(val2==max)
            //    {
            //        max = val2;
            //    }
            //    else
            //    {

            //    }
            //}
            for (int i = 0; i < n; i++) //inr a phan tu lon nhat
            {
                if(array1[i]>max)
                {
                    max = array1[i];
                }
            }
            Console.Write("Phan tu lon nhat cua mang tren la:"+max+"\n");
            Console.Write("Cac phan tu chia het cho 2 trong mang la:");
            for (int i = 0; i < n; i++) //in a so chia het cho 2 trong mang
            {
                if (array1[i] %2 ==0)
                {
                    Console.Write(+array1[i] + ",");
                }
            }
            Console.ReadKey();
        }
    }
}
