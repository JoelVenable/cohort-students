using System;
using System.Collections.Generic;


namespace cohort_students
{
  class Organization
  {
    public string Name { get; private set; }

    public Organization(string name)
    {
      Name = name;
    }


    public void DoStuff()
    {


      var ExerciseList = new List<Exercise>();

      Exercise Terniary = new Exercise()
      {
        Name = "Terniary Traveler",
        Language = "Javascript"
      };

      Exercise Nutshell = new Exercise()
      {
        Name = "Nutshell",
        Language = "Javascript"
      };

      Exercise ReactNutshell = new Exercise()
      {
        Name = "Reactive Nutshell",
        Language = "Javascript/React"
      };

      ExerciseList.Add(Terniary);
      ExerciseList.Add(Nutshell);
      ExerciseList.Add(ReactNutshell);



      var C30 = new Cohort() { Name = "Day Cohort 30" };
      var C31 = new Cohort() { Name = "Day Cohort 31" };
      var C32 = new Cohort() { Name = "Day Cohort 32" };



      var sean = new Student() { FirstName = "Sean", LastName = "Glavin" };
      var ricky = new Student() { FirstName = "Ricky", LastName = "McConnell" };
      var joel = new Student() { FirstName = "Joel", LastName = "Venable" };
      var april = new Student() { FirstName = "April", LastName = "Fools" };

      C32.AddStudentToCohort(sean);
      C32.AddStudentToCohort(ricky);
      C32.AddStudentToCohort(joel);
      C32.AddStudentToCohort(sean);





    }



    static void AddStudentToCohort(Student student, Cohort cohort)
    {

    }


  }
}