using System;

class Readme{
    
    /*
        DRY => Do not Repaet Yourself

        Object Oriented Programming : The principle states that a programming language or a project is made of 
            objects.
            The objects are made of classes which are also called the building block of an object.
            All files are regarded as a class in OOP and at the same time an object.

        Characteristics of OOP
        => Inheritance: Ability of a child class to take up properties or use existing properties from a parent 
            class. e.g A boy inherits two eyes from the human. A boy inherits the ability to think from a homo-sapien
            class.

            The ':' is used to extend a child class to the parent class
        
        => Encapsulation: It is the art of hiding properties of a class from public access

            Access Modifier: They are used to modify the scope of a particular object.
            - Public : Allows an object to be accessible from all other objects within the project
            - Private : Private objects are only accessible within the defining class
            - Protected : Protected Objects are only accessible within the class and implementing classes
            - Internal : Internal objects are only accessible within the same assembly e.g dlls.
            - Static :

        => Polymorphism: Is simply the ability of an object to take different forms or appear in different forms


        Dot Notation: It is used to access the properties and methods of a class from another class.


        => Abstraction: is the art of hiding important business logic implementations away from the user. 
            It is achieved using Interface and Abstract classes which makes use of the override and overload
            command. 

            //TODO
            Bonus: Webservice vs REST API is a very good example of abstraction
                Webservices exposes the logic
                REST API exposes the data

            - Interface: These are contracts bindings between a class and a fellow implementing class
            - Abstract Classes: These are classes containing one or more abstract methods


        =========== Classes ==============
        Objects
        Program files
        Building blocks of Objects

        Classes => Modeled Objects / Model of objects / Object templates

        classes contains attributes and methods.
        Attributes are made of variables;
        while methods describe the functions to be performed or performed by a class.

        What are variables: \
            Something that  changes
            Something that takes different forms
            :=> Variables are dynamic and changeable containers for values.

            Declaring variables:
                variables are declared in different ways, however the shortest variable will contain 
                    1. DataType;
                    2. Variable Name; 
                    3. It is terminated with a semi-colon;

                    e,g: int sum;
                         string firstname;
                         string bankName;
                         decimal PI;
                         boolean isValid;

            On a broader scope, a variable contains;
            1. access modifier which is private by default
            2. Data type
            3. Variable name
            4. optional default value 
            5. semi colon.

            e.g public string bankName = "Union Bank of Nigeria";
                private int age;
                private decimal PI;
                
                volume of air = 22.4dm3
                volume of YewKel air = 25 dm3

        DataTypes: Data types are the grouping of information or data in programming. 
            with Objects been the base type for all data types.
        Examples of DT in C#:
        => Primitive
            -> Integers: Numbers (Whole numbers), size : 4 bytes
            -> Boolean : True or False, 1 or 0, size: 2 bytes
            -> Float : 4 byte
            -> Double : 8 byte
            -> Decimal : 16 byte
            -> Char : 'a', 'b', '1', 'y', '@', '!'
            -> Null : void, empty, nothing, abstract,
            -> Long : 8 bytes
            -> Short : 2 bytes
            -> String : Alpha-numeric characters. E.g Texts, mix of numbers and characters or alphabets.

        => Derived DataTypes
        - Functions
        - Arrays
        - References
        - Pointers

        Arrays: They are container-like in-memory storage used to hold values of the same data type.
            They are zero based index storage. 
            They are referenced from 0 to the size - 1
            They are denoted by [] in c#
            They store finite number of values
            They are only accessible (Writing and Reading) through the use of their index value
            Array values are printed using a loop mechanism.

            - Declaring an array
            public string[] bankBranches;
            public string bankBranches[];
            public int[] numbers;
            private int[] ages;
            private char[] alphabets;

            - Instantiating and array
*/
            //1. 
            public string[] bankBranches = new string[5]{"Ikeja", "V.I", "Lekki", "Yaba", "Marina"};

            //2.
            public string[] bankNames = new string[6];
            public static int[] numbers = new int[3]{1, 2, 3};
            
            public static void Mains(){
                
/*      - Accessing an array
                => Writing into an array
    */          
            Readme readme = new Readme();
            readme.bankBranches[0] = "Somolu";
            readme.bankBranches[4] = "Bariga";

            readme.bankNames[0] = "UBA";
            readme.bankNames[2] = "UBN";
            readme.bankNames[5] = "FBN";

            }

    /*      - Accessing an array
                => Reading from an array
    */ 
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            int thirdNumber = numbers[2];
            
            int sum = numbers[0] + numbers[2];


//Side Note
    //Concatenation: The addition or joining of two strings in programming
    // firstname + " "+ secondname => Yewande Akinjewe : Happens when one or more of the added variables is a
    // string

/*
    Declaring Classes
    Classes are declared or created using the below syntax;
    {access modifiers} class(keyword) {class name} {}

    On class creation in C#, five default methods are bundled with the created class which are inherited from 
    an Object base class.
    The methods include:
        - Equals
        - HashCode
        - ToString
        - GetType

    The above methods are immediately created after a class creation and are useable on creation.
    The methods are also overrideable to customize the functions they perform.

    There is a 5th hidden method that comes with your class, and it is call a no-arguement constructor.
    => Constructors: The default method used in setting up your class.
        They have same name as the class themselves
        They can be overriden and also customized.

    ========= Week Assignement ============
    1. Write a custotmer class with only 1 required arguement constructor, supply as many fields as possible
    2. Write a Customer Account Class which inherits from Customer class and has a required args constructor that includes two of the fields from the Customer class.


    ============ Week 4 classwork ==================
    Write a class (Dog/Table) with 5 properties each;
    define two required arguement constructors with atleast 2 - 3 fields each, 
    override the ToString method of the class

    Instantiate the class in the program.cs class
    Print the values within the class on the console.

    =============== Assignment =============
    Write 3 new classes with atleast two reqired arguement constructors
    Define 3 instances each of your classes;
    Print the values of your classes on the console, screen grab the output 
        and add it to a folder call output in the project

    Write a calculator class with two properties, 
        define 4 methods within the class to handle four different arithmetic operations of your choosen.

    push to the repo before next class.
*/
    
}
