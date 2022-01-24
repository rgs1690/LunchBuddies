using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchBuddies.Models;

namespace LunchBuddies.Models
{
    internal class Restaurant
    {
        public string Name { get; set; }
        private List<string> _restarauntList = new List<string>()
        {
            "Nadeens", "TennFold", "Party Fowl", "Nectar", "Sindore", "Simply Thai" 
        };
        public Restaurant()
        {
            Random rnd = new Random();
            string rand = _restarauntList[rnd.Next(_restarauntList.Count)];

            Name = rand; }

      
        }
    
}
