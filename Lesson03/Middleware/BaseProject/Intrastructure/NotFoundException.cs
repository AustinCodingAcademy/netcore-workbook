using System;
namespace BaseProject.Intrastructure
{
    public class NotFoundException: Exception
    {
        public NotFoundException(string username)
        {
            Console.WriteLine("Exception Thrown");

        }
    }
}
