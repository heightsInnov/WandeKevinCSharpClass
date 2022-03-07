using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin
{
    internal class Money
    {
       public string[] notes = new string[8]{ "5", "10", "20", "50", "100", "200", "500", "1000" };
       int check = 
       public string printColour(string note)
       {
           if (notes.IndexOf(note) == -1 )
           {
               int check = note.IndexOf(notes)

     
               Console.WriteLine("Note doesn't exist");
           }
           else
           {
               Console.WriteLine("Note dey ground");
           }
           return note;
       }
    }
}
