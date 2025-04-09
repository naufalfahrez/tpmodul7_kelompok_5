using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace Faiz
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

    public class DataMahasiswa_1030223330048
    {
        public void ReadJSON()
        {
            string filePath = "C:\\Users\\Faiz\\OneDrive - Telkom University\\Documents\\KS4\\KPL\\PRAKTIKUM\\tpmodul7_kelompok_5\\tp7_1_103022300048.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan.");
            }
        }
    }
}
