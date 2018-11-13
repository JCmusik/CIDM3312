## In-Class Using Simple Razor Views

This is another in-class assignment that builds on your previous "Math Library" in-class assignment (from the previous week).

#### Here are the instructions:

* Understand ALL OF THE SAME STEPS as previous (listed again below for convenience):

* Previous In-Class Practice HTTP GET with ASP.NET MVC Routes and Controllers

1. Create a new ASP.NET MVC Core project called MyWebCalculator
2. Create a new ASP.NET MVC Controller called CalculatorController
3. Create Action Methods for Add, Subtract, Multiply, Divide, Power, Ceiling, and Floor
4. All of the above must be implemented in a separate class library
5. You will reference the DLL only in your MVC project
6. Create the required parameters for each of the above methods

#### Updates for this Exercise

Now, rather than returning a string, we will return a Razor View.  We will use Bootstrap to show the output in Razor Views.  So, now the updated and additional instructions are:

1. For each method, return a templated Razor view that constructs a sentence/phrase indicating the operands given and the result of the operation
2. From a browser, call each method using the appropriate url route and arguments.
Submission

### Submission of this work includes:

##### Pushing this code to github
* Zipping up the solution directory and uploading that to this box.
* Demonstrating that a randomly-selected method works when I visit you to inspect the work.