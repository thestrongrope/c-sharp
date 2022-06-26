// What is grade
// Grade = Marks
// If Next Multiple of 5 of Marks - Grade < 3 grade = next Multiple of 5
// 11 / 5 = 2 * 5 = 10 => 15
// 67 / 5 = 13 * 5 = 65 => 70
// 9 / 5 = 1 * 5 = 5 => 10
// generating a random number between 0 and 100
// int marks = (new Random()).Next(0, 100);

int[] studentMarks = { 35, 45, 84, 29, 57, 73, 67, 38, 33};

List<int> studentGrades = studentMarks.ToList();
List<int> newGrades = new List<int>();
foreach(int marks in studentGrades) {
    newGrades.Add(getGrade(marks));
}

for(int i = 0; i < studentGrades.Count; i++) {
    int marks = studentGrades[i];
    int grade = newGrades[i];
    Console.WriteLine($"Marks: {marks}. Grade: {grade}");
}

int getGrade(int marks) {

    if(marks < 38) return marks;

    int grade;
    grade = marks;

    int nextMultipleOf5;
    nextMultipleOf5 = ( ( marks / 5 ) * 5 ) + 5;

    int difference = nextMultipleOf5 - grade;

    if ( difference < 3 ) grade = nextMultipleOf5;

    return grade;
}