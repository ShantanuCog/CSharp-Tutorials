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
    // Add grades to student
    public Grades grades;

    // constructor to initialise the student with grades and age
    public Student(string firstName, string lastName, int age, Grades grades) {
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
      this.grades = grades;
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

    // constructor
    public Grades(double inputMathsGrade, double inputEnglishGrade) {
      mathsGrade = inputMathsGrade;
      englishGrade = inputEnglishGrade;
    }
    
    // Methods: calculateAvgGrade() -> return average of english & maths grade
    public calculateAvgGrade() {
      int avgGrade = (mathsGrade + englishGrade) / 2;
      return avgGrade;
    }
  }

  Grades grades1 = new Grades(45.5, 67);
  
  Student student1 = new Student(); // instantiate an object
  
  student1.FirstName = "John"; // set student1's firstName to "John"
  student1.LastName = "Doe";   // set student1's lastName to "Doe"
  student1.Age = 18;           // set student1's age to 18

//   Console.log(Student1.FirstName);
// display the average grade of student1
  Console.log(student1.grades.calculateAvgGrade());
  
}

class StudentModel {
  // columns: Student ID, First Name, Last Name, Age
}

class GradeModel {
    // We would like to associate the student with the grade
    // columns: Grade ID, Maths, English + Student ID
}

