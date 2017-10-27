using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// All console commands must be in the sub-namespace Commands:
namespace ConsoleApplicationBase.Commands
{
    // Must be a public static class:
    public static class oadrCommands
    {
        // Methods used as console commands must be public and must return a string

        public static string start()
        {
            var result = "Not Implemented"
            return result;
        }

        public static string stop()
        {
            var result = "Not Implemented"
            return result;
        }


        public static string quit()
        {
            var result = "Not Implemented"
            return result;
        }


        public static string status()
        {
            var result = "Not Implemented"
            return result;
        }


        public static string listEvents()
        {
            var result = "Not Implemented"
            return result;
        }


        public static string queryRegistration()
        {
            var result = "Not Implemented"
            return result;
        }

        public static string reRegister()
        {
            var result = "Not Implemented"
            return result;
        }


        public static string registerReport()
        {
            var result = "Not Implemented"
            return result;
        }



        public static string addMarketContext(string data = "http://MarketContext.html")
        {
            var result = "Not Implemented"
            return result;
        }


        public static string listMarketContext()
        {
            var result = "Not Implemented"
            return result;
        }


        public static string addResource(string data = "Resource1")
        {
            var result = "Not Implemented"
            return result;
        }


        public static string listResources()
        {
            var result = "Not Implemented"
            return result;
        }


/**
        public static string DoSomething(int id, string data)
        {
            return string.Format(ConsoleFormatting.Indent(2) + 
                "I did something to the record Id {0} and saved the data '{1}'", id, data);
        }


        public static string DoSomethingElse(DateTime date)
        {
            return string.Format(ConsoleFormatting.Indent(2) + "I did something else on {0}", date);
        }


        public static string DoSomethingOptional(int id, string data = "No Data Provided")
        {
            var result = string.Format(ConsoleFormatting.Indent(2) + 
                "I did something to the record Id {0} and saved the data {1}", id, data);

            if(data == "No Data Provided")
            {
                result = string.Format(ConsoleFormatting.Indent(2) + 
                "I did something to the record Id {0} but the optinal parameter "
                + "was not provided, so I saved the value '{1}'", id, data);
            }
            return result;
        }
        
        **/
        
    }
}
