using System;

namespace IncrementDecrement__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 45;
            Console.WriteLine("Nilai A (Tanpa Assginment)                = {0}", A);

            A = A + 5; //Assignment dengan variabel yang sama
            Console.WriteLine("\nNilai A (1x Assginment/Tambah dengan 5)   = {0}", A);
            A = A + 7; //Assignment dengan variabel yang sama
            Console.WriteLine("Nilai A (2x Assginment/Tambah dengan 7)   = {0}", A);
            A += 3; //A = A + 3
            Console.WriteLine("Nilai A (3x Assginment/Tambah dengan 3)   = {0}", A);
            
            A = A - 5; //Assignment dengan variabel yang sama
            Console.WriteLine("\nNilai A (1x Assginment/Kurang dengan 5)   = {0}", A);
            A = A - 7; //Assignment dengan variabel yang sama
            Console.WriteLine("Nilai A (2x Assginment/Kurang dengan 7)   = {0}", A);
            A -= 3; //A = A - 3
            Console.WriteLine("Nilai A (3x Assginment/Kurang dengan 3)   = {0}", A);

            A = A * 5; //Assignment dengan variabel yang sama
            Console.WriteLine("\nNilai A (1x Assginment/Kali dengan 5)     = {0}", A);
            A = A * 7; //Assignment dengan variabel yang sama
            Console.WriteLine("Nilai A (2x Assginment/Kali dengan 7)     = {0}", A);
            A *= 3; //A = A x 3
            Console.WriteLine("Nilai A (3x Assginment/Kali dengan 3)     = {0}", A);

            A = A / 5; //Assignment dengan variabel yang sama
            Console.WriteLine("\nNilai A (1x Assginment/Bagi dengan 5)     = {0}", A);
            A = A / 7; //Assignment dengan variabel yang sama
            Console.WriteLine("Nilai A (2x Assginment/Bagi dengan 7)     = {0}", A);
            A /= 3; //A = A / 3
            Console.WriteLine("Nilai A (3x Assginment/Bagi dengan 3)     = {0}", A);

            A = A % 5; //Assignment dengan variabel yang sama
            Console.WriteLine("\nNilai A (1x Assginment/Modulus dengan 5)  = {0}", A);
            A = A % 7; //Assignment dengan variabel yang sama
            Console.WriteLine("Nilai A (2x Assginment/Modulus dengan 7)  = {0}", A);
            A %= 3; //A = A modulus 3
            Console.WriteLine("Nilai A (3x Assginment/Modulus dengan 3)  = {0}", A);

            A = 45; //Assignment Ulang Nilai Dari Variabel
            Console.WriteLine("\nAssignment Ulang Nilai A                 = {0}", A);
            A++; //Increment
            Console.WriteLine("Nilai A setelah Increment (After) 1x     = {0}", A);
            A++; //Increment
            Console.WriteLine("Nilai A setelah Increment (After) 2x     = {0}", A);
            ++A; //Increment
            Console.WriteLine("Nilai A setelah Increment (Before) 1x    = {0}", A);
            ++A; //Increment
            Console.WriteLine("Nilai A setelah Increment (Before) 2x    = {0}", A);

            A = 45; //Assignment Ulang Nilai Dari Variabel
            Console.WriteLine("\nAssignment Ulang Nilai A                 = {0}", A);
            A--; //Decrement
            Console.WriteLine("Nilai A setelah Decrement (After) 1x     = {0}", A);
            A--; //Decrement
            Console.WriteLine("Nilai A setelah Decrement (After) 2x     = {0}", A);
            --A; //Decrement
            Console.WriteLine("Nilai A setelah Decrement (Before) 1x    = {0}", A);
            --A; //Decrement
            Console.WriteLine("Nilai A setelah Decrement (Before) 2x    = {0}", A);

            Console.ReadLine();
        }
    }
}
