
using System.Text.RegularExpressions;

namespace CurWork.AbstractClasses
{
    public class ValidationHelper
    {
        public static string Property { get; set; }
        public static string isValid()
        {
            Property =  Console.ReadLine();

            if (Regex.IsMatch(Property, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                return Property;
            }
            return default(string);

        }
    }
}
