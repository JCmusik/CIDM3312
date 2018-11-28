## Mid-Term Exam Two: ASP.NET Core

This exam asks that you create an ASP.NET Form, handle the POST data and show a result

### Exam Activities

1. Create an ASP.NET MVC Core application
Create a Model Class called "MathOperation" with the following properties:  
   1. LeftOperand (will be a decimal)
   2. Right Operand (will be a decimal)
   3. Operator (will be Addition, Subtraction, Multiplication, Division)
   4. Result (will be a decimal)

2. Create a Controller called "MathController"
   1. Will have an ActionMethod called "DoCaclucation" which responds to HttpGet request
   2. Will create and send to the view as a model an instance of the "MathOperation" class to be bound to your form elements using ASP.NET Core tag helpers
   3. Will have an ActionMethod called "ShowCalculationResults" which responds to the HttpPost you would return form data binding the model to the form

3. Use Bootstrap to create each Razor Template (a view for DoCalculation - which contains the form - and a view for ShowCalculationResults - which contains the results of the calculation)
   1. Don't forget that you need to create the model in the contoller and pass it to the view
   2. You need to specify the use of the model in the View using the @model directive in the View
   3. You need to use tag helpers in the form to specify which controller and view will be handling the POST data from the form
   4. Wire up the MathLibrary you've completed for a previous assignment to this ASP.NET MVC project in order to perform the required calcuations


### How to submit this work
Create or add to an existing repository at Github and push your final solution to that repository.  Please then submit the URL to your repo here.
Also, ZIP up the repo and submit here to this dropbox.