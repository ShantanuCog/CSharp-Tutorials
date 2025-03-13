// namespace: defining the context, container for classes
namespace school {

    // Classes: Students, Grades, Teachers, Classes
  
    // obtain and set properties of the students
  class Student {
    private string firstName     // private field (inaccesible)
    public string FirstName {    // property (pathway to accessibility)
      get { return firstName; }  // get the firstName
      set { firstName = value; } // set the firstName to 'value'
    }
    public string lastName;
    public int age;

    // Methods: Introduce() -> "Hello, my name is 'firstName, 'lastName'"
    //          StateAge() -> "I am 'age' years old"
  } 

  // obtain and grades of students
  class Grades {
    
    // obtain and set maths grades of students
    private double mathsGrade
    public double MathsGrade {
      get { return mathsGrade; }  // get the mathsGrade
      set { mathsGrade = value; } // set the mathsGrade to 'value'
    }

    // obtain and set english grades of students
    private double englishGrade
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
      int avgGrade = (mathsGrade+englishGrade)/2;
      return avgGrade;
    }
  }

    /*
    Functional Spec: Student will take in the Grade arguments of english and maths grade
    Student will be able to calculate their avg grade from their given maths/english grades
    Caveat: We cannot put calculateAvgGrade() in student class (Must follow SRP)
    */

  Grades grades1 = new Grades(45.5, 67);
  
  Student student1 = new Student(); // instantiate an object
  
  student1.FirstName = "John"; // set student1's firstName to "John"

  Console.log(Student1.FirstName);
  
}

class StudentModel {
  // columns: Student ID, First Name, Last Name, Age
}

class GradeModel {
    // We would like to associate the student with the grade
    // columns: Grade ID, Maths, English + Student ID
}

