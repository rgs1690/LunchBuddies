// See https://aka.ms/new-console-template for more information
using LunchBuddies.Models;


var restaraunt1 = new Restaurant();
Console.WriteLine(restaraunt1.Name);
List<LunchBuddy> lunchBuddies = new List<LunchBuddy>();
var lunchBuddy1 = new LunchBuddy("Steve", "Hawkins");
var lunchBuddy2 = new LunchBuddy("Jessica", "Wharmby");
var lunchBuddy3 = new LunchBuddy("John", "Ritch");
lunchBuddy1.Eat();
lunchBuddy1.Eat("Steak");
lunchBuddies.Add(lunchBuddy1);
lunchBuddies.Add(lunchBuddy2);
lunchBuddies.Add(lunchBuddy3);

lunchBuddy1.Eat(lunchBuddies);
lunchBuddy2.Eat("pizza", lunchBuddies); 