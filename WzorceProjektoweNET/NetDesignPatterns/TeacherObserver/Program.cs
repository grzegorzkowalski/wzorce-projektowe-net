using TeacherObserver;

var teacher = new Teacher();
var grzegorz = new Student("Grzegorz");
var pawel = new Student("Paweł");
var jan = new Student("Jan");

teacher.addObserver(grzegorz);
teacher.addObserver(pawel);
teacher.addObserver(jan);

var newResults = new List<Result>()
    {
        new Result(21, "Grzegorz"),
        new Result(25, "Paweł"),
        new Result(15, "Jan"),
    };

teacher.addResults(newResults);