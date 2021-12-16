# Logic-Expression-Classes
This is a collection of scripts that will make logical expressions easier!
There are currently 5 logical expressions (their class names):
  Class: ANDGates
  Method: AND()

  Class: ORGates
  Method: OR()

  Class: XORGates
  Method: OR()

  Class: NANDGates
  Method: NAND()

  Class: NORGates
  Method: NOR()

Each method has 7 overloads, meaning you can have up to 7 inputs in each logic gate. Of course, this limit can be surpassed by nesting the methods within other methods.
Each method is also static, meaning there's no need to make an instance of the classes before using the methods.
The methods return true when their logic expression's requirements are met, and false if they aren't.
Here is an example calling of said methods:

bool a = false;
bool b = true;

bool c = ORGates.OR(a, b);

In this case, c will be assigned "true".

This is a work in progress, I plan to make this a full package that can be implemented into future programs!
