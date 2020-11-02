# Bees
Bee Exercise 

Here's my take on the bee exercise. I timed myself and this took me around 50 minutes including comments and this readme file.

I have created it as a console application because it is the easiest to use for handling data, unless the UI is extensive but for this exercise it seems more appropriate to keep it to a console application. 

I have separated the bee classes so that Queen, Drone and Worker are classes that inherit the class Bee, this is so that code is as effecient as possible and avoids repeating code. 

The only method in the child classes is the method for determining whether the bee is dead, as the values are different for each bee. This is updated as soon as the damage method is called, providing the bee is actually damaged. (subject to errors or if it is already dead)

After damaging, the bee statuses are printed in a list of workers, queens and drones so that we can see them easily and in a nice format. There is still however, only one single list of bees.

I use the random class within System to get the number for the damage that will be applied to each bee. Using 81 as a parameter because it is exclusive of the max value. This would therefore return something 0 to 80 respectively.

To keep it simple, there is a simple while(true) loop with a break that is used to allow the user to damage the bees, or exit the application. 
Once bees are damaged, the updated health and death states of each bee is printed for you automatically.

To ensure health cannot reduce below 0, upon being damaged, I check whether the health is below 0 and if so, it is set to 0 as anything below 0 is irrelevant to the exercise.

Thank you for reading!
