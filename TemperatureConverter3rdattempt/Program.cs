using System;


namespace TemperatureConverter3rdattempt
{
    class Program
    {
        static void Main(string[] args)
        {
            InputandShow();
        }
            private static void InputandShow()
            {
                int inputCelsius = CtoF();                             
                Console.ReadLine();
                int inputFahrenheit = FtoC();                
                Console.ReadLine();                
                Console.WriteLine("Congratulations you have now converted from Celsius to Fahrenheit and vice versa! your Answers = " + Convert.ToString(inputCelsius) + " " + "and" + " " + Convert.ToString(inputFahrenheit));
                Console.ReadLine();                
            }       

            public static int CtoF()          
            {
                //User input Celsius.            
                Console.WriteLine("Please input your temperature in Celsius? "); 
                int Celsius = int.Parse(Console.ReadLine());             
                //Console.ReadLine();
                //Conversion parameters for Celsius to Fahrenheit.
                int cTof = ((Convert.ToInt32(Celsius) * 9) / 5) + 32;
                Console.WriteLine("The Fahrenheit value is " + cTof);
                Console.ReadLine();
                return cTof;
            }  
        
            public static int FtoC()
            {
                //User input Fahrenheit.  
                Console.WriteLine("Please input your temperature in Fahrenheit? ");
                int FahInput = int.Parse(Console.ReadLine());            
                Console.WriteLine();
                //Conversion parameters for Celsius to Fahrenheit.
                int fToc = ((Convert.ToInt32(FahInput) - 32) * 5) / 9;
                Console.WriteLine("The Celsius value is " + fToc);
                //Console.ReadLine();
                return fToc;            
            }

        #region Old practice code
                        /*static int userInput(int Celsius, int Fahrenheit)
                {
                if (Celsius == Convert.ToInt32("C"))
                {
                   //User input Celsius.

                   Celsius = int.Parse(Console.ReadLine());
                   Console.WriteLine("Please input your temperature in Celsius? " + Celsius);
                   Console.ReadLine();

                   //Conversion parameters for Celsius to Fahrenheit.
                   int cTof = ((Convert.ToInt32(Celsius) * 9) / 5) + 32;
                   Console.WriteLine("The Fahrenheit value is {0}:" + cTof);
                   Console.ReadLine();
                   return cTof;
                }

                else if (Fahrenheit == Convert.ToInt32("F"))
                {

                   //User input Fahrenheit.
                   Console.WriteLine("Please input your temperature in Fahrenheit? ");
                   int FahInput = int.Parse(Console.ReadLine());
                   Console.WriteLine();

                   //Conversion parameters for Celsius to Fahrenheit.
                   int fToc = ((Convert.ToInt32(FahInput) - 32) * 5) / 9;
                   Console.WriteLine("The Celsius value is {0}:", fToc);
                   Console.ReadLine();

                   return fToc;
                }

                else
                { 
                   Console.WriteLine("Sorry please try again");
                }*/ 
        #endregion
    }
}
