using System;
class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[7];

        students[0] = new Student { name = "Иванов И.И.", group = 101, grades = new int[] { 4, 5, 4, 3, 5 } };
        students[1] = new Student { name = "Петров П.П.", group = 102, grades = new int[] { 3, 4, 4, 4, 5 } };
        students[2] = new Student { name = "Сидоров С.С.", group = 103, grades = new int[] { 5, 5, 5, 5, 5 } };
        students[3] = new Student { name = "Козлов К.К.", group = 101, grades = new int[] { 4, 4, 4, 4, 4 } };
        students[4] = new Student { name = "Алексеев А.А.", group = 102, grades = new int[] { 3, 3, 3, 3, 3 } };
        students[5] = new Student { name = "Николаев Н.Н.", group = 103, grades = new int[] { 2, 3, 2, 4, 3 } };
        students[6] = new Student { name = "Григорьев Г.Г.", group = 101, grades = new int[] { 5, 5, 4, 5, 5 } };


        for (int i = 1; i < students.Length; i++)
        {
            Student key = students[i];
            int j = i - 1;
            while (j >= 0 && students[j].Calculate() > key.Calculate())
            {
                students[j + 1] = students[j];
                j = j - 1;
            }
            students[j + 1] = key;
        }

 
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.name}, Группа: {student.group}, Средний балл: {student.Calculate()}");
        }
    }
    struct Student
    {
        public string name;
        public int group;
        public int[] grades;

        public double Calculate()
        {
            double sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }
    }
}

