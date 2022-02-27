using System;

public class Calculator
    {
    // Defining Properties of Calculator Class
    public decimal firstNumber { get; set; }
    public decimal secondNumber { get; set; }


    // Defining a Two-Argument Constructor
    public Calculator(decimal firstNumber, decimal secondNumber)
    {
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
    }


    // Defining Methods of Calculator Class
    public decimal SumOf()
    {
        decimal sum = firstNumber + secondNumber;
        return sum;
    }

    public decimal DifferenceOf()
    {
        decimal diff = firstNumber - secondNumber;
        return diff;
    }

    public decimal ProductOf()
    {
        decimal product = firstNumber * secondNumber;
        return product;
    }

    public decimal RatioOf()
    {
        decimal ratio = firstNumber / secondNumber;
        return ratio;
        // consider decimal
    }

}