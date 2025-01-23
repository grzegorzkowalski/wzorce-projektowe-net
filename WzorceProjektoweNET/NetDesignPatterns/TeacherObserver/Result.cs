namespace TeacherObserver
{
    internal class Result
    {
        public int Score { get; set; }
        public string Name { get; set;}
        internal Result(int score, string name)
        {
            Score = score;
            Name = name;
        }
    }
}
