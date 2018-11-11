## Unit Converter App

## Reference a .dll directly
The following XML should be added to the .csproj file from which you want to reference another project using just the .dll
```xml
    <ItemGroup>
        <Reference Include="full/path/projectfolder/obj/Debug/targetframework/YourLibraryName.dll" />
    </ItemGroup>
```
## Assignment Seven

#### Please write a simple ASP.NET MVC Core application that serves as a unit converter.  Please convert between the following unit types:

* Temperatures - Celsius, Fahrenheit, Kelvin
* Length - Meters, Feet, Yards
* Mass - Ounce, Pound, Gram, Kilogram
* This will consist of a simple controller.  

You will use an HTML form, expressed in a Razor template, to * * HTTP POST the data base to the controller.\
Then, when the calculation is complete, we will redirect to show the results in a separate template page.

#### Submit Work

Push to github and supply the URL for your work.  Upload your project directory ZIPPED up here.

-------------------------
### Temperatures

#### Celsius to Fahrenheit

Multiply the Celsius temperature by 9 Divide the answer by 5 Add 32

#### Fahrenheit to Celsius

Subtract 32 from the Fahrenheit temperature Divide the answer by 9 Multiply that answer by 5

#### Celsius to Kelvin

K = °C + 273.15

#### Kelvin to Celsius

°C = K - 273.15

#### Fahernheit to Kelvin

T(K) = (T(°F) + 459.67)× 5/9

#### Kelvin to Fahernheit

T(°F) = T(K) × 9/5 - 459.67


-----------------------
### Lengths

#### Meters to Feet

Meters / 0.3048

#### Feet to Meters

Feet * 3.2808

#### Meters to Yards

Meters * 1.0936132983

#### Yards to Meters

Yards * 0.9144

#### Feet to Yards

Feet * 0.3333333333

#### Yards to Feet

Yards * 3

------------------
### Mass   

#### Ounces to Pound

Ounce * 0.062500

#### Pound to Ounce 

Pound * 16

#### Ounce to Gram

Ounce / 0.035274

#### Gram to Ounce

Gram * 0.035274

#### Ounce to Kilogram

Ounce / 35.274

#### Kilogram to Ounce

Kilogram * 35.274

#### Pound to Gram

Pound / 0.0022046

#### Gram to Pound

Gram * 0.0022046

#### Pound to Kilogram

Pound / 2.2046

#### Kilogram to Pound

Kilogram * 2.2046

#### Gram to Kilogram

Gram * 1000

#### Kilogram to Gram

Kilogram / 1000

