using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41
{
    delegate void StringProcessor(string input);

    class SimpleDelegateUse
    {

            static void Main(string[] args)
        {
            Person jon = new Person("Jon");
            Person tom = new Person("Tom");
            BackGound airplane = new BackGound();


        StringProcessor jonsVoice = new StringProcessor(jon.say);
        StringProcessor tomsVoice = new StringProcessor(tom.say);
        StringProcessor backgound = new StringProcessor(airplane.Note);

            jonsVoice("Hello, son.");
            tomsVoice("Hello, daddy!");
            backgound("(An airplane flies past)");


        }
    }

  
}
