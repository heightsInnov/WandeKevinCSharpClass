using System;

public class Calculator
{
    // Defining Properties of Calculator Class
    public int firstNumber { get; set; }

    public int secondNumber { get; set; }

    public Calculator(int firstNumber, int secondNumber)
    {
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
    }

    // Defining Methods of Calculator Class
    public int SumOf()
    {
        int sum = firstNumber + secondNumber;
        return sum;
    }

    public int DifferenceOf()
    {
        int diff = firstNumber - secondNumber;
        return diff;
    }

    public int ProductOf()
    {
        int product = firstNumber * secondNumber;
        return product;
    }

    public int RatioOf()
    {
        int ratio = firstNumber / secondNumber;
        return ratio;
        // consider decimal
    }

}