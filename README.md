# CSharp-Book-1-Chapter-6-Common-Types-HashSets-CarLot
(Done) - Quick exercise to understand hashsets and how to use them.


Practice: Car Sets
Setup
mkdir -p ~/workspace/csharp/exercises/sets && cd $_
dotnet new console
References
C# HashSet
Instructions
Create an empty HashSet named Showroom that will contain strings.
Add four of your favorite car model names to the set.
Print to the console how many cars are in your show room.
Pick one of the items in your show room and add it to the set again.
Print your showroom again, and notice how there's still only one representation of that model in there.
Create another set named UsedLot and add two more car model strings to it.
Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
You've sold one of your cars. Remove it from the set with the Remove() method.
Acquiring more cars
Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
Create a new HashSet of your show room with HashSet<string> clone = new HashSet<string>(Showroom);
Use the IntersectWith() method on the clone to see which cars exist in both the show room and the junkyard.
Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
