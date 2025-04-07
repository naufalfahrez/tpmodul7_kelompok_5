using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace tpmodul7_kelompok_5
{
    public class Matkul
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class MatkulList
    {
        public List<Matkul> courses { get; set; }
    }
    class KuliahMahasiswa_1020330096
    {
        public void ReadJson()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_2_103022330096.json");

            string JsonString = File.ReadAllText(filePath);
            MatkulList data = JsonSerializer.Deserialize<MatkulList>(JsonString);

            Console.WriteLine($"Daftar mata kuliah yang diambil:");
            for (int i=0; i<data.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
            }
        }
    }
}
