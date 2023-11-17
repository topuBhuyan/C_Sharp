/*
 
using System;
    namespace objet_creation;

internal class program
{
    class Person
    {
       
    }

    static void Main(string[] args)
    {
       
    }
}
 */

// Clasas and Object

/*
using System;
    namespace objet_creation;

internal class program
{
    class Person
    {
        public string name;
        public int age;

        public void introducYourself()
        {
            Console.WriteLine("I'm" + name + " and I'm " + age+ " years old.") ;
        }
    }

    static void Main(string[] args)
    {
        Person personObject = new Person();

        // set properties
        personObject.name = " Topu ";
        personObject.age = 20;

        personObject.introducYourself();
    }
}
*/


// Public And Private

/*
using System;
namespace objet_creation;

internal class program
{
    class Person
    {
        // set default vlaue for id
        private string id = "1";
        public string name;
        public int age;

        public void printData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Id: " + id);
        }
    }

    static void Main(string[] args)
    {
        Person personObject = new Person();

        personObject.name = "John";
        personObject.age = 20;

        personObject.printData();
    }
}
*/

// This Keywrd
/*
using System;
namespace objet_creation;

internal class program
{
    class Rectangle
    {
        private double width;
        private double height;

        public void setWidth(double width)
        {
            //Modify object's member
            this.width = width;
        }
        public void setHeight(double height)
        {
            //Modify object's member
            this.height = height;
        }
        public double claArea()
        {
            //Acces class member
            return this.height * this.width;
        }
        public void printData()
        {
            Console.WriteLine("Width = " + this.width);
            Console.WriteLine("Height = " + this.height);

            //Acces class function
            double area = this.claArea();
            Console.WriteLine("Area = " + area);
        }
    }

    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();

        rectangle.setWidth(3);
        rectangle.setHeight(2);

        rectangle.printData();
    }
}
*/

/// Getters And Setters 

//using System;
//namespace objet_creation;

//internal class program
//{
//    public class Square
//    {
//        // getter and default value for side
//        public double side { get; } = 4;
//    }

//    static void Main(string[] args)
//    {
//        Square square = new Square();

//        // usage of getter
//        double side = square.side;

//        // square.side = 8
//       Console.WriteLine(side);
//    }
//}


//using System;
//namespace objet_creation;

//internal class program
//{
//    class Person
//    {
//        //geter and default vlaue for side
//        public string name { get; set; }
//        public int age { get; set; }

//        public void printData()
//        {
//            Console.WriteLine("Name: " + name);
//            Console.WriteLine("Age: " + age);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Person person = new Person();
//        person.name = "Emily";
//        person.age = 20;
//        person.printData();
//    }
//}

//Customizing getters and setters
/*
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace objet_creation;

internal class program
{
    class Square
    {
        double _side;
            public double side
        {
            get
            {
                return Math.Round(_side, 2);
            }
            set
            {
                Console.WriteLine("Value to be set: " + value);
                if(value <= 0)
                {
                    return;
                }
                this._side = value;
            }
        }
        public double calArea()
        {
            return _side * _side;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Square 1: ");
        Square square_1 = new Square();
        square_1.side = 222.11245;

        Console.WriteLine("Side = " + square_1);
        Console.WriteLine("Area = " +square_1.calArea());

        Console.WriteLine("------------");
        Console.WriteLine("Square 2:");

        Square squre_2 = new Square();
        squre_2.side = -1;

        Console.WriteLine("Side = " + squre_2.side);
    }
}
*/


// Constructors

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Person
//    {
//        public string name { get; set; }
//        public int age { get; set; }
//    }

//    static void Main(string[] args)
//    {
//        Person person = new Person();
//        Console.WriteLine("Name : " + person.name);
//        Console.WriteLine("age : " + person.age);
//    }
//}

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Person
//    {
//        public string name { get; set; }
//        public int age { get; set; }

//        public Person()
//        {
//            Console.WriteLine("Object creation. ");

//            name = "Unknown";
//            age = 0;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Person person = new Person();
//        Console.WriteLine("Name: " + person.name);
//        Console.WriteLine("Age: " + person.age);
//    }
//}

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Person
//    {
//        public string name { get; set; }
//        public int age { get; set; }

//        /// parameterized constructor -1 argument
//        public Person(int ageValue)
//        {
//            Console.WriteLine("Constructor with 1 parameter.");
//            this.age = ageValue;
//        }
//        public Person(string nameValue, int ageValue)
//        {
//            Console.WriteLine("Constructor with 2 parameters.");
//            this.name = nameValue;
//            this.age = ageValue;
//        }
//        public void printData()
//        {
//            Console.WriteLine("Name: " + this.name);
//            Console.WriteLine("Age: " + this.age);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Person person_1 = new Person(17);
//        Person person_2 = new Person("Alex", 21);

//        person_1.printData();
//        Console.WriteLine("----------");
//        person_2.printData();
//    }

// Class inheritance Basics

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Vehicle
//    {
//        public double getInsuranceCost(int months)
//        {
//            return 0;
//        }
//    }
//    class scooter : Vehicle
//    {
//        public double getInsuranceCost(int months)
//        {
//            return months * 15;
//        }
//    }
//    class Car : Vehicle
//    {
//        public double getInsuranceCost(int months)
//        {
//            return months * 25;
//        }
//    }
//    class Bicycle : Vehicle
//    {

//    }
//    static void Main(string[] args)
//    {
//        scooter scooter = new scooter();
//        Console.WriteLine("Scooter Year Insurance: " + scooter .getInsuranceCost(12) + " $ ");

//        Car car = new Car();
//        Console.WriteLine("Car Year Insurance: " + car.getInsuranceCost(12) + " $ ");

//        Bicycle bike = new Bicycle();
//        Console.WriteLine("Bicycle Year Insurance: " + bike.getInsuranceCost(12) + " $ ");
//    }
//}

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Vehicle
//    {
//        protected string brand;
//        protected string model;

//        public Vehicle(string brandValue, string modelValue)
//        {
//            brand = brandValue;
//            model = modelValue;

//            Console.WriteLine("Vehicle constructor");
//        }
//        public void representation()
//        {
//            Console.WriteLine("Brand: " + brand);
//        }
//    }
//    class Car : Vehicle
//    {
//        private int horsePowers;

//        public Car(string brandValue, string modelValue, int horsePosersValue) 
//         : base(brandValue, modelValue)
//        {
//            Console.WriteLine("Car constructor");

//            horsePowers = horsePosersValue;
//        }
//        public void representation()
//        {
//            base.representation();

//            Console.WriteLine("Models: " + model);
//            Console.WriteLine("Horse Powers: " + horsePowers);
//        }
//    }
//    static void Main(string[] args)
//    {
//        Vehicle sampleBicycle = new Vehicle("Merida ", "ONE-FORTY 800");
//        sampleBicycle.representation();
//        Console.WriteLine("--------------");

//        Car fordCar = new Car("Ford", "Fiesta", 80);
//        fordCar.representation();
//        Console.WriteLine("------------");

//        Car toyotaCar = new Car("Toyota", "Corolla", 100);
//        toyotaCar.representation();
//    }
//}

///Class inheritance Advanced

//using System;
//namespace objet_creation;

//internal class program
//{
//    class A
//    {
//        protected string a;

//        public void printA()
//        {
//            Console.WriteLine(a);
//        }
//    }
//    class B : A
//    {
//        protected string b;
//        public void printB()
//        {
//            Console.WriteLine(b);
//        }
//    }
//    class D : C
//    {
//        private string d;
//        public void printD()
//        {
//            Console.WriteLine(d);
//        }
//        public D(string aValue, string bValue, string cValue, string dValue)
//        {
//            a = aValue;
//            b = bValue;
//            c = cValue;
//            d = dValue;
//        }
//    }
//    static void Main(string[] args)
//    {
//        D sampleObject = new D("AValue", "BValue", "CValue", "DValue");
//        sampleObject.printA();
//        sampleObject.printB();
//        sampleObject.printC();
//        sampleObject.printD();
//    }
//}

// Interfaces

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Vehicle
//    {
//        double getInsuranceCost(int months)
//          {
//            return 25 * months;
//        }
//}
//    class Car : Vehicle
//    {
//        public double getInsuranceCost(int months)
//        {
//            return 25 * months;
//        }
//    }
//    class Bicycle : Vehicle
//    {
//        public double getInsuranceCoset(int months)
//        {
//            return 0;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Car car = new Car();
//        Console.WriteLine("Car's Year Insurance: " + car.getInsuranceCost(12) + "$");

//        Bicycle bicycle = new Bicycle();
//        Console.WriteLine("Bike's Year Insurance: " + bicycle.getInsuranceCoset(12) + "$");
//    }
//}


// Abwtract Classes 
//using System;
//namespace objet_creation;

//internal class program
//{
//    class Vehicle 
//    {
//        public double getInsuranceCost(int months)
//        {
//            return 0;
//        }
//    }
//    class Car : Vehicle
//    {
//        public double getInsuranceCost(int months)
//        {
//            return 25 * months;
//        }
//    }
//    class Bicycle : Vehicle
//    {

//    }
//    static void Main(string[] args)
//    {
//        Car car = new Car();
//        Console.WriteLine("Car's Year Insurance: " + car.getInsuranceCost(12) + " $ ");

//        Bicycle bicycle = new Bicycle();
//        Console.WriteLine("Bike's Year Insurance: " + bicycle.getInsuranceCost(12) + " $ ");
//    }
//}

//Abstract methods
//using System;
//namespace objet_creation;
//abstract class program
//{
//    abstract class Figure
//    {
//        public abstract double calcArea(); 
//    }
//    class Square : Figure
//    {
//        public double side { get; set; }
//        public Square(double sideValue)
//        {
//            this.side = sideValue;
//        }
//        public override double calcArea()
//        {
//            return side * side;
//        }
//    }
//    class Rectangle : Figure
//    {
//        public double width { get; set; }
//        public double height { get; set; }

//        public Rectangle(double widthValue, double heightValue)
//        {
//            this.width = widthValue;
//            this.height = heightValue;
//        }
//        public override double calcArea()
//        {
//            return width * height;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Square square = new Square(2);
//        Rectangle rectangle = new Rectangle(3, 2);

//        Console.WriteLine("Square's area: " + square.calcArea());
//        Console.WriteLine("Rectangle's area: " + rectangle.calcArea());
//    }
//}

/*
/// Static Members
using System;
namespace objet_creation;

internal class program
{
    class Car
    {
        private string model;

        public Car(string modelValue)
        {
            Console.WriteLine("Object created");
            model = modelValue;
            carsCount++;
        }
        public static int carsCount;
    }

    static void Main(string[] args)
    {
        Car.carsCount = 0;
        Console.WriteLine("Initial Cars Count: " + Car.carsCount);

        Car carobj1 = new Car("Toyota Corolla");
        Car carobj2 = new Car("Peugeot 508");
        Car carobj3 = new Car("Renault clio");

        Console.WriteLine("Final Cars Count: " + Car.carsCount);
    }
}
*/

/// Encapsulation Principle

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Car
//    {
//        private string _model;
//        private int _manifactureYear;

//        public string model
//        {
//            get
//            {
//                return _model;
//            }
//            set
//            {
//                _model = value;
//            }
//        }
//        public int manifactureYear
//        {
//            get
//            {
//                return _manifactureYear;
//            }
//            set
//            {
//                _manifactureYear = value;
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        Car car = new Car();
//        car.model = "Toyto Corolla";
//        car.manifactureYear = 2023;

//        Console.WriteLine("Year: " + car.manifactureYear);
//        Console.WriteLine("Model: " + car.model);
//    }
//}

/// Abstraction Principle
//using System;
//namespace objet_creation;
//internal class program
//{
//    class Triangle
//    {
//        private double a;
//        private double b;
//        private double c;

//        public Triangle(double aVal, double bVal, double cVal)
//        {
//            a = aVal;
//            b = bVal;
//            c = cVal;
//        }
//        public double calcArea()
//        {
//            double p = (a + b + c) / 2;
//            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//            return area;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Triangle triangle = new Triangle(3, 4, 5);
//        Console.WriteLine("Area = " + triangle.calcArea());
//    }
//}

/// Polymorphism Principle
/*
using System;
namespace objet_creation;

internal class program
{
    class Sumator
    {
        public double sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double sum(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
    }

    static void Main(string[] args)
    {
        Sumator sumator = new Sumator();
        Console.WriteLine(" 1 + 2 = " + sumator.sum(1,2));
        Console.WriteLine("3 + 4 + 5 = " + sumator.sum(3,4,5));
    }
}
*/
//using System;
//namespace objet_creation;

//internal class program
//{
//    class Figure
//    {
//        public double calcArea()
//        {
//            return 0;
//        }
//    }
//    class Square : Figure
//    {
//        private double side;
//        public Square(double sideValue)
//        {
//            side = sideValue;
//        }
//        public double calcArea()
//        {
//            return side * side;
//        }
//    }
//    class Triangle : Figure
//    {
//        private double a;
//        private double b;
//        private double c;

//        public Triangle(double aVal, double bVal, double cVal)
//        {
//            a = aVal;
//            b = bVal;
//            c = cVal;
//        }
//        public double calcArea()
//        {
//            double p = (a + b + c) / 2;
//            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//            return area;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Square square = new Square(2);
//        Console.WriteLine("Square Area = " + square.calcArea());

//        Triangle triangle = new Triangle(3, 4, 5);
//        Console.WriteLine("Triangle Area = " + triangle.calcArea()) ;
//    }
//}
// List of Object 
/*
// Collectio Of Classes 
using System;
namespace objet_creation;
internal class program
{
    class Car 
    {
        public string model { get; set; }
        public double price { get; set; }

        public Car(string model, double price)
        {
            this.model = model;
            this.price = price;
        }
        public void printData()
        {
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Price: " + this.price);
        }
    }
    class carDealarship
    {
        public List<Car> cars { get; set; }
    }
    static void Main(string[] args)
    {
        carDealarship carDealarship = new carDealarship();

        carDealarship.cars = new List<Car>()
        {
            new Car ("Toyota Corolla", 2500),
            new Car ("Ford Fiesta", 20000),
        };

        carDealarship.cars.Add(new Car("Renault Clio", 20000));

        Console.WriteLine("Car's count: " + carDealarship.cars.Count);

        foreach (Car car in carDealarship.cars)
        {
            Console.WriteLine();
            car.printData();
        }
    }
}
*/
/// Compareto Method

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Smartphone : IComparable
//    {
//        public string model { get; set; }
//        public string price { get; set; }

//        public Smartphone(string model, double price)
//        {
//            this.model = model;
//            this.price = price;
//        }
//        public int CompareTo(object obj)
//        {
//            Smartphone smartphone = (Smartphone)obj;

//            if (smartphone.price > this.price)
//            {
//                return -1;
//            }
//            else if(smartphone.price == this.price)
//            {
//                return 0;
//            }
//            return 1;
//        }
//    }
//    class Shop
//    {
//        public List<Smartphone> smartphnes;

//        public Shop()
//        {
//            this.smartphnes = new List<Smartphone>();
//        }
//    }
//    static void Main(string[] args)
//    {
//        Shop shop = new Shop();

//        Smartphone phone_1 = new Smartphone("Samsung Galaxy S 20", 1300);
//        Smartphone phone_2 = new Smartphone("Iphone 11", 2600);
//        Smartphone phone_3 = new Smartphone("Samsung Galaxy Fold", 2400);

//        shop.smartphnes.Add(phone_1);
//        shop.smartphnes.Add(phone_2);
//        shop.smartphnes.Add(phone_3);

//        shop.smartphnes.Sort();

//        foreach(Smartphone smartphone in shop .smartphnes)
//        {
//            Console.WriteLine("__________");
//            Console.WriteLine(smartphone.model);
//            Console.WriteLine(smartphone.price);
//        }
//    }
//}

//// Descending Sort

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Smartphone : IComparable
//    {
//        public string model { get; set; }
//        public double price { get; set; }

//        public Smartphone(string model, double price)
//        {
//            this.model = model;
//            this.price = price;
//        }
//        public int CompareTo(object obj)
//        {
//            Smartphone smartphone = (Smartphone)obj;

//            if (smartphone.price < this.price)
//            {
//                return -1;
//            }
//            else if (smartphone.price == this.price)
//            {
//                return 0;
//            }
//            return 1;
//        }
//    }
//    class Shop
//    {
//        public List<Smartphone> smartphones;

//        public Shop()
//        {
//            this.smartphones = new List<Smartphone>();
//        }
//    }
//    static void Main(string[] args)
//    {
//        Shop shop = new Shop();

//        Smartphone phone_1 = new Smartphone("Samsung Galaxy S 20", 1300);
//        Smartphone phone_2 = new Smartphone("Iphone 11", 2600);
//        Smartphone phone_3 = new Smartphone("Samsung Galaxy Fold", 2400);

//        shop.smartphones.Add(phone_1);
//        shop.smartphones.Add(phone_2);
//        shop.smartphones.Add(phone_3);

//        shop.smartphones.Sort();

//        foreach (Smartphone smartphone in shop.smartphones)
//        {
//            Console.WriteLine("_____________");
//            Console.WriteLine(smartphone.model);
//            Console.WriteLine(smartphone.price);
//        }
//    }
//}
///
//using System;
//namespace objet_creation;

//internal class program
//{
//    class Smartphone : IEquatable<Smartphone>
//    {
//        public string model;
//        public double price;

//        public Smartphone(string model, double price)
//        {
//            this.model = model;
//            this.price = price;
//        }
//        public bool Equals(Smartphone smartphone)
//        {
//            return this.model == smartphone.model &&
//                this.price == smartphone.price;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Smartphone phone_1 = new Smartphone("Iphone 11", 2500);
//        Smartphone phone_2 = new Smartphone("Iphone 11", 2600);
//        Smartphone phone_3 = new Smartphone("Iphone 11", 2600);
//        Smartphone phone_4 = new Smartphone("Samsung Galaxy Fold", 2600);

//        if (phone_1.Equals(phone_2))
//        {
//            Console.WriteLine("phone 1 and phone 2 are the same.");
//        }
//        if (phone_2.Equals(phone_3))
//        {
//            Console.WriteLine("phone 2 and phone 3 are the smae.");
//        }
//        if (phone_3.Equals(phone_4))
//        {
//            Console.WriteLine("phone 3 and phone 4 are the same.");
//        }
//    }
//}

//// Equals and contains Methods

//using System;
//namespace objet_creation;

//internal class program
//{
//    class Smartphone : IEquatable<Smartphone>
//    {
//        public string model;
//        public double price;

//        public Smartphone(string model, double price)
//        {
//            this.model = model;
//            this.price = price;
//        }
//        public bool Equals(Smartphone smartphone)
//        {
//            return this.model == smartphone.model;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Smartphone phone_1 = new Smartphone("Iphone 11", 2500);
//        Smartphone phone_2 = new Smartphone("Iphone 11", 2600);
//        Smartphone phone_3 = new Smartphone("Oneplus 7", 1200);
//        Smartphone phone_4 = new Smartphone("Samsung Galaxy Fold", 2600);
//        Smartphone phone_5 = new Smartphone("Samsung Galaxy S20", 1700);

//        List<Smartphone> smartphones = new List<Smartphone>();
//        smartphones.Add(phone_1);
//        smartphones.Add(phone_4);

//        if (smartphones.Contains(phone_1))
//        {
//            Console.WriteLine("phone_1's model is contained in the array");
//        }
//        if(smartphones.Contains(phone_2))
//        {
//            Console.WriteLine("phone_2's model is contained in the array");
//        }
//        if(smartphones.Contains(phone_3))
//        {
//            Console.WriteLine("phone_3's model is containded in the array");
//        }
//        if(smartphones.Contains(phone_4))
//        {
//            Console.WriteLine("phone_4's model is containded in the array");
//        }
//        if(smartphones.Contains(phone_5))
//        {
//            Console.WriteLine("Phone_5's model is contained in the array");
//        }
//    }
//}

/// Try Catch

//using System;
//    namespace objet_creation;

//internal class program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            Console.WriteLine("Executing try block code. ");
//            throw new Exception("My error message.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Catching an error: ");
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

using System;
namespace objet_creation;

internal class program
{
    class Person
    {
        public string name { get; set; }
        public int age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Age cannot be less than zero.");
                }
                age = value;
            }
        }
        public Person(string usernameValue, int ageValue)
        {
            this.name = usernameValue;
            this.age = ageValue;
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Person personObj = new Person("Alex", -1);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Object creation failed: ");
            Console.WriteLine(ex.Message);
        }
    }
}