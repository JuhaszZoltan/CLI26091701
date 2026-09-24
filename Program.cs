using System.Text;

#nullable disable

const string FilePath = "..\\..\\..\\data\\titanic.txt";

List<Category> categories = [];

using StreamReader sr = new(FilePath, Encoding.UTF8);
while (!sr.EndOfStream) categories.Add(new(sr.ReadLine()));