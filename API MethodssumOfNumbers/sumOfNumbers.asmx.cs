using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace API_MethodssumOfNumbers
{
    /// <summary>
    /// Summary description for sumOfNumbers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class sumOfNumbers : System.Web.Services.WebService
    {

       

        [WebMethod]
        public int sumOfNumbersForEach(List<int> numbers)
        {
           
            int Total = 0;

            if (numbers.Count> 0)
            {
                for ( int i = 0; i < numbers.Count; i++)
                {
                    Total = Total + numbers[i];
                }
                return Total;
            }
            else  return 0;

        }
        [WebMethod]
        public int sumOfNumberswhileloop(List<int> numbers)
        {
            int Total = 0;
            int i = 0;

            if (numbers.Count > 0)
            {
                while(i<numbers.Count )
                {
                    Total = Total + numbers[i];
                    i++;

                }
                return Total;
            }
            else  return 0;

        }

        [WebMethod]
        public int sumOfNumbersrecursion(List<int> numbers, int listNumbers)
        {
          
            int i = numbers.Count;
            if (listNumbers <= 0)
            {
                return 0;
            }  else {
                    return (sumOfNumbersrecursion(numbers, listNumbers-1) + numbers[listNumbers -1]);
                   
                }
              
           

        }
    }
}
