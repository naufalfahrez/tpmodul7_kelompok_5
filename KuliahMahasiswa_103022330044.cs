using System.Text.Json;

namespace Rakan
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    public class KuliahMahasiswa_103022330105
    {
        public void ReadJSON()
        {
            string filePath = "C:\\Users\\Rakan\\Documents\\Telkom\\SMT4\\ADPL\\TPMOD7\\tp7_2_103022330044.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);

                    CourseList data = JsonSerializer.Deserialize<CourseList>(jsonString);

                    Console.WriteLine("Daftar mata kuliah yang diambil:");

                    int nomor = 1;
                    foreach (var mk in data.courses)
                    {
                        Console.WriteLine($"MK {nomor} {mk.code} - {mk.name}");
                        nomor++;
                    }
                }
                else
                {
                    Console.WriteLine("File JSON tidak ditemukan di: " + Path.GetFullPath(filePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}