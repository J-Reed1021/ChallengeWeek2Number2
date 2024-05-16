using System.IO;

namespace SystemIOWriteDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
            ReadFile();
        }


        static void WriteFile()
        {
            Console.WriteLine("Enter your name:");
            string myName = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string myAddress = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int myAge = Convert.ToInt32(Console.ReadLine());
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\MSSA\\Test.txt");
                //Write a line of text
                sw.WriteLine("Hello " + myName);
                //Write a second line of text
                sw.WriteLine("Your address is: " + myAddress);
                sw.WriteLine("Your age is: " + myAge);
                sw.WriteLine("From CCAD14");
                //Close the file
                sw.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        static void ReadFile()
            {
                string line;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader("C:\\MSSA\\Test.txt");
                    //Read the first line of text
                    line = sr.ReadLine();
                    //Continue to read until you reach end of file
                    while (line != null)
                    {

                        //write the line to console window
                        Console.WriteLine(line);
                        //Read the next line
                        line = sr.ReadLine();

                    }
                    //close the file
                    sr.Close();
                    Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block. ");
                }

            }
        }
    }
