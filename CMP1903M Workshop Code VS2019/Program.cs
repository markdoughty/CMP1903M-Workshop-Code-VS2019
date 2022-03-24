using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code_VS2019
{
    class Program
    {
        static void Main(string[] args)
        {

            //Week 5
            //Challenge: What are the valid pass phrases?
            //



            //Week 5
            //Task 1: Add a page to the 'history'
            //Task 2: Add exceptions
            //Task 3: Use custom exceptions

            //example of creating a page with a title and URL
            //Test... remove this when you have seen it working
            Page p = new Page("Test Page", "http://www.lincoln.ac.uk");
            Console.WriteLine(p.Address);
            //.......

            //creating a new, empty history
            History h1 = new History();
        }

    }
}
