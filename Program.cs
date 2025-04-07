using Faiz;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1030223330048 mahasiswa = new DataMahasiswa_1030223330048();
        mahasiswa.ReadJSON();

        var kuliah = new KuliahMahasiswa_103022300048();
        kuliah.ReadJSON();
    }
}
