namespace TeacherObserver
{
    internal class Teacher
    {
        private List<Result> _results;
        private List<Student> _students = new();

        internal void addObserver(Student student)
        {
            _students.Add(student);  
        }
        internal void addResults(List<Result> results)
        {
            _results = results;
            Notify();
        }
        internal void Notify()
        {
            foreach (var item in _students)
            {
                item.GetResult(_results.FirstOrDefault(s => s.Name == item.Name));
            }
        }
    }
}
