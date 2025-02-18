namespace ArbeitLinq;

public class Person : Object
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }

    public Person(string firstname, string Lastname, Gender gender)
    {
        this.Gender = gender;
        this.FirstName = firstname;
        this.LastName = Lastname;
    }

    public override string ToString()
    {
        //return base.ToString();
        return $"Name: {FirstName} {LastName}";
    }
}

