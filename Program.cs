using Rakan;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1030223330044 mahasiswa = new DataMahasiswa_1030223330044();
        var kuliah = new KuliahMahasiswa_103022330105();

        mahasiswa.ReadJSON();
        kuliah.ReadJSON();
    }
}
