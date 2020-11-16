using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCoreLib
{
    /// <summary>
    /// sfdkjdfgjkjk sdkjlfdkjlfljk fk
    /// </summary>
    public class Analytics
    {
        /// <summary>
/// Это метод выдает популярные месяцы
/// </summary>
/// <param name="dates"></param>
/// <returns></returns>
        public List<DateTime> PopularMonths(List<DateTime> dates)
        {

            List<DateTime> newList = new List<DateTime>();

            foreach ( var  item in  dates)
            {
                var d = new DateTime();
                d= d.AddYears(item.Year);
                d= d.AddMonths(item.Month);
               d= d.AddDays(item.Day);

                newList.Add(d); 
            }

            newList = newList.Distinct().ToList();

            newList.Sort();


            return newList;
        }
        
    }
}
