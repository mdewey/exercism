using System;
using System.Collections.Generic;
using System.Linq;



public class Student
{
  public int Grade { get; set; }
  public string Name { get; set; }
}

public static class MyExtensions
{
  public static IEnumerable<string> ReturnStudents(this IOrderedEnumerable<Student> students) => students.Select(s => s.Name).ToArray();
}

public class GradeSchool
{
  private List<Student> _roster = new List<Student>();

  public void Add(string student, int grade)
  {
    this._roster.Add(new Student { Name = student, Grade = grade });
  }

  public IEnumerable<string> Roster()
  {
    return _roster.OrderBy(o => o.Grade).ThenBy(t => t.Name).ReturnStudents();
  }

  public IEnumerable<string> Grade(int grade)
  {
    return _roster.Where(o => o.Grade == grade).OrderBy(o => o.Name).ReturnStudents();
  }
}