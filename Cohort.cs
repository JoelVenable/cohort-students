using System;
using System.Collections.Generic;

namespace cohort_students
{
  class Cohort
  {
    public string Name { get; set; }

    public List<Student> Students { get; private set; } = new List<Student>();

    public List<Instructor> Instructors { get; private set; } = new List<Instructor>();

    public void AddStudentToCohort(Student studentToAdd)
    {
      Students.Add(studentToAdd);
    }

    public void AddInstructor(Instructor instructorToAdd)
    {
      Instructors.Add(instructorToAdd);
    }
  }
}