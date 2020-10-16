using System;


namespace work_6
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  class Person
  {
    private string name;
    private string surname;
    private System.DateTime dateOfBirth;

    public Person(string _name, string _surname, DateTime _dateOfBirth)
    {
      name = _name;
      surname = _surname;
      dateOfBirth = _dateOfBirth;
      
    }
    public Person()
    {
      name = null;
      surname = null;
    }

      public string Name
      {
        get {
          return name;
        }

        set {
          name = value;
        }
      }

    public string Surname
    {
      get {
        return surname;
      }

      set {
        surname = value;
      }
    }
    public DateTime DateOfBirth
    {
      get {
        return dateOfBirth;
      }

      set {
        dateOfBirth = value;
      }
    }
    public int YearOfBirth
    {
      get {
        return dateOfBirth.Year;
      }

      set {
        dateOfBirth.Year = value;
      }
    }

    public virtual string ToShortString() { return name + "  " + surname; }
  }








}
