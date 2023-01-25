using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Person
{
    internal class Person
    {
        private int id;
        private string fistName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        public int Id { get => this.id; set => this.id = value; }
        public string FistName { get => this.fistName; set => this.fistName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string FavoriteColor { get => this.favoriteColor; set => this.favoriteColor = value; }
        public int Age { get => this.age; set => this.age = value; }
        public bool IsWorking { get => this.isWorking; set => this.isWorking = value; }


        public Person(int id, string fistName, string lastName,string favoriteColor, int age, bool isWorking) 
        {   this.id = id;
            this.fistName = fistName; 
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

   

        public override string ToString()
        {
            string formatted=" ";

            formatted += "PersonID:"+ id + "\n";
            formatted += "Frist name:" + FistName +"\n";
            formatted += "Last name: " + LastName + "\n";
            formatted += "Favorite Colour: " + FavoriteColor + "\n";
            formatted += "age: " + age + "\n";
            formatted += "Is working: " + isWorking + "\n";
            return formatted;
        }
       
        public void DisplayPersonInfo()
        {
            Console.WriteLine( this.id+":" + this.fistName + this.lastName + " favorite color is " + this.favoriteColor);
        }

        public void ChangeFavoriteColor()
        {
            this.favoriteColor = "White";
            Console.WriteLine(this.id + ":" + this.fistName + this.lastName + " favorite color is " + this.favoriteColor);
        }
       
        public void GetAgeInTenYears()
        {
            this.age += 10;
            Console.WriteLine(this.id + ":" + this.fistName + this.lastName + " age in 10 years is :" + this.age);
        }
    }

}
