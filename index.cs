    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
               public static Tuple<int, bool, string> Main(){
                var myInt = "17";
                var myBool = "False";
                var myString = 100;
                
                var myIntConverted = int.Parse(myInt);
                var myBoolConverted = bool.Parse(myBool);
                var myStringConverted = myString.ToString();
                
                
                 return new Tuple<int, bool, string>
                    (myIntConverted, myBoolConverted, myStringConverted);
            }
        }
    }