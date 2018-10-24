## Unit Converter
### Assignment Six

Please write a simple ASP.NET MVC Core application that serves as a unit converter.

##### Please convert between the following unit types:
* Temperatures - Celsius, Fahrenheit, Kelvin
* Length - Meters, Feet, Yards
* Mass - Ounce, Pound, Gram, Kilogram

This will consist of a simple controller.\
You will use query string parameters to send the units and unit data into the controller to get a web page response (for now, there is NO UI Input)

##### Newtonsoft Json serialization/deserialization command
dotnet add package Newtonsoft.Json --version 11.0.2

### Temperatures
#### Celsius to Fahrenheit
Multiply the Celsius temperature by 9
Divide the answer by 5
Add 32

#####Fahrenheit to Celsius
Subtract 32 from the Fahrenheit temperature
Divide the answer by 9
Multiply that answer by 5

#### Celsius to Kelvin
K = °C + 273.15

#### Kelvin to Celsius
°C = K - 273.15

#### Fahernheit to Kelvin
T(K) = (T(°F) + 459.67)× 5/9

#### Kelvin to Fahernheit
T(°F) = T(K) × 9/5 - 459.67