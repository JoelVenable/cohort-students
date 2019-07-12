using System;

using System.Collections.Generic;


namespace cohort_students
{
  class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    { get { return $"{FirstName} {LastName}"; } }

    public string SlackHandle { get; set; }


    private List<Exercise> _exercises = new List<Exercise>();
    private List<Exercise> _finishedExercises = new List<Exercise>();

    public Cohort Cohort { get; set; }


    public void AddExercise(Exercise newExercise)
    {
      _exercises.Add(newExercise);
    }

    public void CompleteExercise(Exercise completedExercise)
    {
      if (_exercises.Contains(completedExercise))
      {
        _exercises.Remove(completedExercise);
        _finishedExercises.Add(completedExercise);
      }
      else
      {
        throw new Exception($"{completedExercise} was not found!");
      }
    }

    public void PrintStatusReport()
    {
      Console.WriteLine("--------------");
      Console.WriteLine($"{FullName} is working on:");
      _exercises.ForEach(exercise =>
      {
        Console.WriteLine($"{exercise.Name}, in {exercise.Language}");
      });
      Console.WriteLine($"{FullName} has finished:");
      _finishedExercises.ForEach(exercise =>
      {
        Console.WriteLine($"{exercise.Name}, in {exercise.Language}");
      });


    }

  }
}