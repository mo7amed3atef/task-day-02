Solution:

1) Why the output of this Equation = $30.00 ?
--> We used the `Currency` format, which adds the `$` symbol to the number and adds two zeros after the decimal point.
   We can control the number of zeros after the decimal point. For example, if we use `C1`, there will be only one zero after the decimal point, and similarly,
   if we use `C2`, there will be two zeros after the decimal point.

2) what is its benefit?
--> It makes numbers related to money easier to read and understand by adding the `$` symbol and formatting the decimal places.

3) try another example with a different specifier with a screenshot of the output.
--> 
double X = 13235.325;
double Y = 25460.452;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:N}");

result -->Equation: 13235.325 + 25460.452 = 38,695.78
The `N` Number format adds commas between thousands, and we can also control the number of digits after the decimal point.


