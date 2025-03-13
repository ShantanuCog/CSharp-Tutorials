/*
Functional Spec: Student class will take in the Grade arguments of english and maths grade
Student class will be able to calculate their avg grade from their given maths/english grades
Caveat: We cannot put calculateAvgGrade() in student class (Must follow SRP)
*/

// namespace: defining the context, container for classes
namespace school {
    // Classes: Students, Grades, Teachers, Classes
    // obtain and set properties of the students

  class Student {
    private string firstName;    // private field (inaccesible)
    public string FirstName {    // property (pathway to accessibility)
      get { return firstName; }  // get the firstName
      set { firstName = value; } // set the firstName to 'value'
    }
    public string lastName;
    public int age;
    // Add grades property to student class
    public Grades grades;

    // constructor to initialise the student with grades and age
    public Student(string inputFirstName, string inputLastName, int inputAge, double mathsGrade, double englishGrade) {
      firstName = inputFirstName;
      lastName = inputLastName;
      age = inputAge;
      grades = new Grades(mathsGrade, englishGrade);
    }

    // Methods: Introduce() -> "Hello, my name is 'firstName, 'lastName'"
    //          StateAge() -> "I am 'age' years old"
  } 

  // obtain and grades of students
  class Grades {
    
    // obtain and set maths grades of students
    private double mathsGrade;
    public double MathsGrade {
      get { return mathsGrade; }  // get the mathsGrade
      set { mathsGrade = value; } // set the mathsGrade to 'value'
    }

    // obtain and set english grades of students
    private double englishGrade;
    public double EnglishGrade {
      get { return englishGrade; }  // get the englishGrade
      set { englishGrade = value; } // set the englishGrade to 'value'
    }

    // obtain average grades of students
    private double avgGrade;
    public double AvgGrade {
      get { return avgGrade; }  // get the avgGrade
    }

    // constructor
    public Grades(double inputMathsGrade, double inputEnglishGrade) {
      mathsGrade = inputMathsGrade;
      englishGrade = inputEnglishGrade;
      avgGrade = calculateAvgGrade();
    }
    
    // Methods: calculateAvgGrade() -> return average of english & maths grade
    public double calculateAvgGrade() {
      return (mathsGrade + englishGrade) / 2;
      // return avgGrade;
    }
  }

  // Grades grades1 = new Grades(45.5, 67);
  // Student student1 = new Student(); // instantiate an object
  // instantiate a student with grades
  // Student student1 = new Student("John", "Doe", 18, new Grades(45.5, 67));
  
//   Console.log(Student1.FirstName);
// display the average grade of student1
}

// namespace: defining the context, container for classes
public class Program {
  public static void Main() {
    // instantiate a student with grades
    school.Grades grades1 = new school.Grades(45.5, 67);
    school.Student student1 = new school.Student("John", "Doe", 18, 45.5, 67);
    // display the name and average grade of student1
    Console.WriteLine("First Name: " + student1.FirstName);
    Console.WriteLine("Last Name: " + student1.lastName);
    Console.WriteLine("Age: " + student1.age);
    Console.WriteLine("Average Grade: " + student1.grades.AvgGrade);
  }
}

class StudentModel {
  // columns: Student ID, First Name, Last Name, Age
}

class GradeModel {
    // We would like to associate the student with the grade
    // columns: Grade ID, Maths, English + Student ID
}