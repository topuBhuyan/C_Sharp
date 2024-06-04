using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emplyee em = new Emplyee("moja", "rahim");
            em.printFullName();
        }
    }
}
class Emplyee
{
    string _firstName;
    string _lastName;

    public Emplyee (string firstName, string lastname)
    {
        _firstName = firstName;
        _lastName = lastname;
    }
    public void printFullName()
    {
        Console.WriteLine("FullNmae : {0} {1}", _firstName, _lastName);
    }
}