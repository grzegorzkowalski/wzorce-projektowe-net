namespace TeacherObserver
{
    internal class Student
    {
        internal string Name { get; set;  }
        internal Student(string name)
        {
            Name = name;
        }

        public void GetResult(Result result)
        {
            Console.WriteLine($"{result.Name} osiągnął wynik {result.Score} i {(result.Score > 20 ? "zdał" : "nie zdał")}.");
        }
    }
}
