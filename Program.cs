// See https://aka.ms/new-console-template for more information
using tpmodul7_kelompok_5;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_103022330096 mahasiswa = new DataMahasiswa_103022330096();
        mahasiswa.ReadJson();

        KuliahMahasiswa_1020330096 kuliah = new KuliahMahasiswa_1020330096();
        kuliah.ReadJson();
    }
}