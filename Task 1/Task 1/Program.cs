
/*3.Simple or Complex number - Ədədin sadə və ya mürəkkəb olub olmamasını tapan alqoritm yazılmalıdır.

Not: Sadə ədədlər yalnız 1-ə və özünə bölünən ədədlərdir. 1 nə sadə nə də mürəkkəb ədəddir. 
Bütün case-lər yoxlanılmalıdır.*/




// bu birinci üsuldur for ilədir.
/*int number = 32;
if (number <= 1)
{
    Console.WriteLine($"{number}: number is neither simple or complex");
}

else
{
    for (int divider = 2; divider <= number; divider++)
    {
        if (number % divider == 0)
        {
            if (number == divider)
            {
                Console.WriteLine($"{number}: number is a simple number");
            }
            else
            {
                Console.WriteLine($"{number}: number is a complex number");
                break;
            }
        }
    }
}
*/

//bu da 2ci üsuldur.While ilədir.
/*int number = 1369;
if (number <= 1)
{
    Console.WriteLine(number + ": number is neither simple or complex number");
}
else
{
    int divider = 2;
    while (divider <= number)
    {
        if (number % divider == 0)
            if (number == divider)
            {
                Console.WriteLine(number + ": number is a simple number");
            }
            else
            {
                Console.WriteLine(number + ": number is  a complex number");
                break;
            }
        divider++;
    }
}*/