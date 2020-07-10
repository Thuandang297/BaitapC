using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ct_dieukhien
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Bai tap cau truc dieu khien");
            Console.WriteLine("nhap so phan tu ban  muon nhap");
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n > 1000 || n < 0);
           
            int[] array = new int[n];
            //nhap cac phan tu vao mang
            Console.WriteLine("Nhap cac phan tu vao mang ban nhe");
            for(int i=0;i<n;i++)
            {
                Console.Write("Array" +(i)+":");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cac phan tu cua mang vua nhap la:");//xuat ra mang
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + array[i]);
            }
            Console.WriteLine();
            //tim phan tu nhor nhat
            int min = array[0];
            for(int i=0;i<n;i++)
            {
                if(array[i]<min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("phan tu nho nhat la:" + min);
            //tim phan tu lon nhat
            int max = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] >max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("phan tu lon nhat la:" + max);
            //sap xep theo chieu giam dan
            int avl;
            for(int i=0;i<n-1;i++)
                for(int j=1;j<n;j++)
            {
                    if(array[i]<array[j])
                    {
                        avl = array[i];
                        array[i] = array[j];
                        array[j] = avl;
                     
                    }
            }
            Console.WriteLine("day so xap sep theo giam dan la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + array[i]);
            }
            //sap xep theo chieu tang dan
            int avl1;
            for (int i = 0; i < n-1; i++)
                for (int j = 1; j < n ; j++)
                {
                    if (array[i] > array[j])
                    {
                      avl1 = array[i];
                        array[i] = array[j];
                        array[j]= avl1;
                     
                    }
                }
            Console.WriteLine();
            Console.WriteLine("day so tang dan la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + array[i]);
            }
            //tinh tong cac so chan
            Console.WriteLine();
            int tongc=0;
            foreach(int chan in array)
            {
                if (chan % 2 == 0)
                {
                    tongc =tongc+ chan;
                }
            }
            Console.WriteLine("Tong cac so chan la:" + tongc);
            //tinh tong cac so chan
            int tongl = 0;
            foreach (int le in array)
            {
                if (le % 2 != 0)
                {
                    tongl = tongl + le;
                }

            }
            Console.WriteLine("Tong cac so le la:" + tongl);
            //xuat ra cac so nguyen to trong mang
            Console.ReadKey();
         
     
        }
    }
}
