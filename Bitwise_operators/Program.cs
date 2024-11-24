int number_1 = 15;
int number_2 = 12;
int result;

// using and (&)
result = number_1 & number_2; // ans 12 because 12 = 1100 and 15 = 1111 binary value than conver decimal = 12
Console.WriteLine($"{number_1} & {number_2} = {result}");

// using or
result = number_1 | number_2; // or condition je kanu akta ture hole sob gula true then decimal convert ans is 15.
Console.WriteLine($"{number_1} | {number_2} = {result}");

// using XOR
result = number_1 ^ number_2; // jodi odd hy tahole true even hole false than convert decimal ans is 3
Console.WriteLine($"{number_1} ^ {number_2} = {result}");

// right shift
result = number_1 >> 2; // dan dike 2 gor shift hobe binary te than j value gula thakbe tar decimal bir korete hobe. ans hobe 3
Console.WriteLine($"{number_1} >> 2 = {result}");

// left shift
result = number_1 << 2;
Console.WriteLine($"{number_1} << 2 = {result}");

