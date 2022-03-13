using System;
class Loops{
    //Loops are continuous execution of certaqin block of code
    /*
        For-Loop
        ForEach
        While-do
        Do-While


        =====For Loops ======
        For loops are used to iterate over a set of values in a finite number of time
        Syntax =>
        for(int {variable} = {initialization}; {condition}; {increment}){

        }
        e.g => 
        for (int i = 0; i < 5; i++){

        }
    */

    static int[] notes = {1, 5, 10, 20, 50, 100, 200, 500, 1000};

    public static void printNotes(){
        for(int i = 0; i < notes.Length; i++){
            Console.WriteLine("This is a "+ notes[i] + " naira note");
        }
    }

    public static void Main(){
        printNotes();
    }
}