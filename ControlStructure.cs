using System;

class ControlStructure{
    //If - Statement
    public void IfMethod(string name, int age){
        if(age <= 12)
            Console.WriteLine(name + " is a minor");

        if(age > 12  && age < 20)
            Console.WriteLine(name + " is a teen");

        if(age >= 20  && age < 50)
            Console.WriteLine(name + " is a adult");

        if(age >= 50)
            Console.WriteLine(name + " is old");
    }

//If - Else Method
    public void IfElseMethod(string name, int age){
        if(age < 18){
            Console.WriteLine(name + " cannot have a beer");
        }
        else{
            Console.WriteLine(name + ", what kind of beer would dyou like?");
        }
    }

    //Multiple If-Else method
    public void MultipleIfElseMethod(string name, int age){
        if(age <= 12)
            Console.WriteLine(name + " is a minor");
        else if(age > 12  && age < 20)
            Console.WriteLine(name + " is a teen");
        else if(age >= 20  && age < 50)
            Console.WriteLine(name + " is a adult");
        else if(age >= 50 && age < 200)
            Console.WriteLine(name + " is old");
        else
            Console.WriteLine("This person should be dead!");
    }

    //While method
    public void WhileMethod(int lengthOfNumbers){
        int number = 0;
        while(lengthOfNumbers <= 5){
            Console.WriteLine("Number is: "+ number++);
            lengthOfNumbers++;
        }  
    }
}