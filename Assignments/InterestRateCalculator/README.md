 # Compound-Interest-Rate-Calculator

## Description
A console app to determine an applicant's interest rate based on the inputs age, gender, and credit score.  Once the interest rate is determined the user can input how much they want to invest and for how many years.  The app then displays the future value of the intial investment.

## Ingredients
```
byte Age
string Gender
short CreditScore
decimal InterestRate
int PresentValue
byte NumberOfYears
decimal[] interestRates      
```

## Instructions
1. Create classes, properties and variables for use in the app
2. Get user input for age, gender, and credit score
3. Validate user inputs and use the valid data to construct a PersonModel object
4. Determine user's interest rate based on age, gender, and credit score
5. Display the age, gender and credit score along with determined interest rate for investment
### Additional Functionality
6. Prompt the user for an amount to invest from 500 to 1,000,000, validate input, and store in corresponding property
7. Prompt the user for the amount of years to invest money from 4 to 20 years, validate input, and store in corresponding property.
8. Calculate compounding interest at 12 times per year based on user inputs, determined interest rate, then display results to the user.

## Completeness
The app will be complete when all inputs have been validated and a correct calculation is displayed back to the user.
