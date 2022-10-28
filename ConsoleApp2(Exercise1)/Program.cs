using System;

namespace Bubble_Sort
{
    class Program
    {
        //Deklarasi array int dengan ukuran 92
        private int[] a = new int[92];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array 
        private int n;

        //Fungsi /method untuk menerima masukan 
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimppan pada array 
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 92)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 92 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_____________________");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("_____________________");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun 
            Console.WriteLine("________________________________");
            Console.WriteLine(" Element array yang teleh tersusun ");
            Console.WriteLine("________________________________");
            for (int ah = 0; ah < n; ah++)
            {
                Console.WriteLine(a[ah]);
            }
            Console.WriteLine("");
            Console.ReadKey();

        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                // Pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int ah = 0; ah < n - 1; ah++)
                {
                    if (a[ah] > a[ah + 1]) // Jika Elemen tidak dalam urutan yang benar 
                    {
                        // tukar element
                        int temp;
                        temp = a[ah];
                        a[ah] = a[ah + 1];
                        a[ah + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of BubbleSort class
            Program mylist = new Program();

            //Pemanggil fungsi untuk menerima elemen array
            mylist.read();
            //Pemnaggil fungsi untuk mengurutkan array

            //Pemanggil fungsi untuk menampilkan array yang tersusun
            mylist.display();
            //Exit
            Console.WriteLine("\n|nTekan Tombol apa saja untuk Keluar.");
        }
    }
}














