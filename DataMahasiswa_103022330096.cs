using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace tpmodul7_kelompok_5
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }
    class DataMahasiswa_103022330096
    {
        public void ReadJson()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_1_103022330096.json");

            string jsonString = File.ReadAllText(filePath);

            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan NIM {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
