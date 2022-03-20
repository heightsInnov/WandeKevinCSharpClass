using System;
using System.Collections.Generic;

//Create a list of 30 students
//Use a foreach loop to print the ages, name and students number of each student

public class Student{
    private string studentNumber {get; set;}
    private string name {get; set;}
    private int age{get; set;}

    public Student(string studentNumber, string name, int age){
        this.studentNumber = studentNumber;
        this.age = age;
        this.name = name;
    }

    public Student createStudent(string studentName, string number, int age){
        Student student = new Student(number, studentName, age);
        return student;
    }

    public List<Student> createMultipleStudents(int numberOfStudents){
        List<Student> students = new List<Student>();
        if(numberOfStudents > 0){
            for(int i = 1; i <= numberOfStudents; i++){
                Student student = createStudent("Student"+i, (080000+i).ToString(), new Random().Next(18, 35));
                students.Add(student);
            }
        }
        return students;
    }

    public override string ToString()
    {
        return "Student " + name + " with student number " + studentNumber + " is of age " + age;
    }

    public static void Main(){
        Student adminStudent = new Student("080000", "Kevin", 40);
        List<Student> students =  adminStudent.createMultipleStudents(30);
        foreach(Student student in students){
            student.ToString();
        }
    }
}