using System;
using Naufal;
using matkul;

namespace program_naufal
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataMahasiswa_103022330105();
            data.ReadJSON();
            var kuliah = new KuliahMahasiswa_103022330105();
            kuliah.ReadJSON();

            Console.ReadKey();
        }
    }
}
