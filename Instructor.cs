using System;

namespace cohort_students
{
  class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }

    public Cohort Cohort { get; set; }

    public string Specialty { get; set; }

    public void AssignExercise(Exercise assignment)
    {

    }

  }
}