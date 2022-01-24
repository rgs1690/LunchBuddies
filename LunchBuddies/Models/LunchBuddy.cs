using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchBuddies.Models;

namespace LunchBuddies.Models
{
    internal class LunchBuddy
    {
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public void Eat( )
        { 
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} is at {restaurant.Name}.");
            
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office");
        }
        public void Eat(List<LunchBuddy> Companions)
        {
            var restaurant = new Restaurant();
            foreach (var companion in Companions)
            {
                Console.WriteLine($"{companion.FirstName} is at {restaurant.Name}");
            }
        }
        public void Eat(string food, List<LunchBuddy>Companions)
        {
            var restaurant = new Restaurant();
            foreach (var companion in Companions)
            {
                Console.WriteLine($"{companion.FirstName} is at {restaurant.Name} and ordered {food}"); 
            }
        }
    }
}
