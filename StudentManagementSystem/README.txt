REASONING BEHIND OOP DESIGN CHOICES:

I decided to implement the Student and Lecturer classes as a hierarchy that inherits from an abstract base class, Person. 
The reason I opted for an abstract base class instead of an interface is that with an interface I would have to repeat the 
same code for implementing the interface properties in each derived class. The abstract base class, Person, allows me to 
define the properties once and then be reused by each of the derived classes, Student and Lecturer. 

I decided not to implement the Degree and Course classes as a hierarchy even though they share similar fields in name and 
duration. The set from which they would receive names are different and their durations are measured differently. Moreover, 
Degree and Course is in a "has a" relationship and not a "is a" relationship.

For the purposes of this project I only included a default constructor and a full paramaterized constructor for each class.
Fully overloaded constructors would be more suitable for a real-world project. 