// TASK: In this task, I will show you some examples of how to work with decimals.
// IN CODE, decimal separator is always DOT regardless of computer language settings.

double piApproximately = 2.2;

// Pi is already available in C#
double piMorePrecisely = Math.PI;

//Decimal numbers have always limited precision
double notCompletelyOne = 0.999999999999999999;

//Outputs
Console.WriteLine("Pi value from our code: " + piApproximately);
Console.WriteLine("Pi value from C#: " + piMorePrecisely);
Console.WriteLine("This should not be exact one: " + notCompletelyOne);

// Waiting for Enter
Console.ReadLine();


/* DISCUSSION: 
 * Please note the following:
    
    • In code, you always need to use a decimal point as a separator
    between the integer and decimal parts of a number.

    • However, the output depends on your Windows settings. As you
    can above, the output on my computer uses a comma
    as a decimal separator since I have my computer set to the Norwegian
    language.

    • You can also see that decimal numbers do not have infinite precision.
    They are rounded after approximately 15 significant digits.
 */