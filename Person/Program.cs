using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Person person1 = new Person(1,"Ian","Brooks","Red",30,true);
            Person person2 = new Person(2,"Gina","James","Green",20,false);
            Person person3 = new Person(3,"Mike","Briscoe","Blue",45,true);
            Person person4 = new Person(4,"Mary","Beals","Yellow",28,true);



            person2.DisplayPersonInfo();

            person1.ChangeFavoriteColor();

            person4.GetAgeInTenYears();
            
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());

        }
    }
}
