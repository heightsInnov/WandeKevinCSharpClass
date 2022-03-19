class NairaNotes{

    static int[] notes = {1, 5, 10, 20, 50, 100, 200, 500, 1000};

    public static string checkNote(int note){
        
        if(!notes.contains(note)){
            return "Invalid naira note supplied";
        }

//1 X 1
//2X1. 2X2
   // int [][] numbers = {{2, 3}, {3, 5}};
//Switch statements are used to transition from one state to the other and this transitioning results in an execution or a response from a block of code.
//Syntax: the syntax for a switch statement is 
/*
    switch(condition){
        case value1:
            statement;
            break;
        case value n:
            statement;
            break;
        default:
            statement;
    }
*/
    // string color = "Gold";

    //     switch(note){
    //         case 10:
    //             color = "Red";
    //             break;
    //         case 20:
    //             color = "Green";
    //             break;
    //         case 50:
    //             color = "Blue";
    //             break;
    //         case 100: 
    //             color = "Brown";
    //             break;
    //         case 200: 
    //             color = "Greenish-Blue";
    //             break;
    //         case 500:
    //             color = "Creemish-Red";
    //             break;
    //         case 1000:
    //             color = "Grey";
    //             break;
    //         default:
    //             if(notes.contains(note))
    //                 color = "Note in Use";
    //             else
    //                 color = "Invalid note supplied";
    //     }

    //Pass color into another array before printing another naira note,
    // Confirm that no two notes has the same color
    //Print a uniquely colored note everytime.

        switch(note){
            case 10:
            case 100:
                return "Brown";
            case 20:
                return "Green";
            case 50:
                return "Blue";
            case 200: 
                return "Greenish-Blue";
            case 500:
                return "Creemish-Red";
            case 1000:
                return "Grey";
            default:
                return "Note in Use";
        }
        // return color;
    }


    /*Assignment
        Implenent the same using a Map dataType
        Implement using a List
    */
}