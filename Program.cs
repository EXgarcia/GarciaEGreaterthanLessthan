//Elizar Garcia
//10-19-22
//Mini Challenge #4 "Greater than or Less than
//The console will promot the user to enter two forms of ints and will compare those values to see if they are greater than or less than,


Console.Clear();

string playGame = "true";
string numOne;
string numTwo;
int num1;
int num2;
string playGameAnswer;
bool answerOne = true;
bool answerTwo = true;
int one = 0;
int two = 0;

while(playGame == "true")
{
    Console.WriteLine("Hello Meat Puppet, Please give me two numbers that I can compare for you.");
    Console.WriteLine("First number please.");

    numOne = Console.ReadLine();
    answerOne = Int32.TryParse(numOne, out one);

    if(answerOne == false)
    {
        Console.WriteLine("Thats not a number. Game over! >:[ ");
        break;
    }else{


    Console.WriteLine("Second number please.");

    numTwo = Console.ReadLine();
    answerTwo = Int32.TryParse(numTwo, out two );

    if(answerTwo == false)
    {
        Console.WriteLine("That is not a number. Game over! >:[ ");
        break;
    }else{

    num1 = Convert.ToInt32(numOne);
    num2 = Convert.ToInt32(numTwo);

    if(num1 > num2)
    {
        Console.WriteLine($" {num1} is greater than {num2} ");
    }else if (num1 < num2)
    {
        Console.WriteLine($" {num1} is less than {num2} ");
    }else{
        Console.WriteLine($" {num1} is equal to {num2} ");
    }

    Console.WriteLine(" Do you want to play again?\nType yes to play again.");
    playGameAnswer = Console.ReadLine().ToLower();

    if(playGameAnswer == "yes")
    {
        playGame = "true";
    }else{
        playGame = "false";
    }
    }
    }
}