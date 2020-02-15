using System;

namespace Dog
{
  public class Dog
  {
    public string name;
    public string owner;
    public int age;
    public Gender gender;
    
    public Dog(string name, string owner, int age, Gender gender)
    {
       this.name = name;
       this.owner = owner;
       this.age = age;
       this.gender = gender;
    }
    
    public class Bark(int barkAmount)
    {
      for (int 1 = 0; i < barkAmount; i++)
      {
        Console.Write("Woof!");
      }
    }
    public class GetTag
    {
        console.writeLine("If lost call {0}, {1} name is {2} and she is {3} {4} old.", owner, gender, name, age, yrs);
        console.ReadLine();
    }
  }
}
