public class Program {
    public static void Main() {
        Car c = new Car();
        c.Wheels = 10;
        c.isRunning = false;
    }
} 

/* 
    Class is a collection of variables and functions

    A field is a variable defined within a class
        fields should always be private
        fields should always be in camelCase
        fields may start with an underscore

        what does it mean if a field is static?

            What is the difference between a Class and an Object?
                -> A class is a definition / blueprint
                    -> a class occupies memory
                        -> functions
                        -> static variables

                -> An object is an instance of a class 
                    -> an object occupies memory
                        -> variables

    A property is a variable defined within a class
        It is a field it is back by a getter function and a setter function
        Should always be public
        Should always be PascalCase
        Will always have a getter and a setter

    A method is a function defined with a class
*/

internal class BankAccount {

    private float accountBalance = 0;
    public float AccountBalance {
        get {
            //Notifier.NotifyAccountHolder();
            return accountBalance;
        }
        set {
            accountBalance = value;
        }
    } 
}

/*

    What is the difference between a Class and an Object?
        -> A class is a definition / blueprint
            -> a class occupies memory
                -> functions
                -> static variables

        -> An object is an instance of a class 
            -> an object occupies memory
                -> variables

    Car.IsCoupe(); // static call

    Static Functions / Static Classes
    Library 

    static Math Library - has no fields or properties
        static Add(int a, int b)
        static Log(int a)
        static Ln(int a)
        static Sin(int a)
    
    (new Car()).IsCoupe(); // non-static call

*/

internal class Car {
    /* Fields */
    private bool isRunning = false;
    /* Properties */
    public int Wheels {get; set;}
    public int Doors {get; set;}
    /* Methods */
    public bool IsCoupe() => Doors == 2;
    public bool IsRunning() => isRunning;
}

// Serializing a class
// Converting a memory object of a class to a file

// access specifier
// public, private, internal, protected

internal class MercedesBenz : Car {
    public new int Doors { get => 4; private set {} }
    public bool FoldableRoof { get; set; }
    public bool LifeInsurance {get;set;}
    public Chair CarChair {get; set;}
}

public class Chair {
    public int Quality {get;set;}
    public bool IsHighQuality => Quality == 5;
}