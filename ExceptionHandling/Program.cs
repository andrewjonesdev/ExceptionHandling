
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sorry, an unexpected divide by zero error occurred.");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Sorry, an unexpected arithmetic error occurred.");
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Sorry, an unexpected system error occurred.");
            }
            catch (Exception ex) //variable for exception not required just the Exception class but by having the variable you can call it later
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally //great for cleaning up unmanaged resources
            {
                Console.WriteLine("Finally.");
            }

            //dynamic streamReader = 0;
            StreamReader streamReader = null;
            Console.WriteLine("Test");
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally //great for cleaning up unmanaged resources
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                    Console.WriteLine("Successfully Disposed!");
                }
            }

            try
            {
                using (var streamReader1 = new StreamReader(@"c:\file.zip")) //automatically sets up hidden finally and dispose this is the prefferable method
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
