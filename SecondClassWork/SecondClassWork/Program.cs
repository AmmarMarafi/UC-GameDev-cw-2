string heroName = "Batman";
float heroPower = 100f;

string villainName = "Scarecrow";
float villainPower = 75f;

if (heroPower > villainPower)
    Console.WriteLine("Batman is stronger than Scarecrow");
else
    Console.WriteLine("Scarecrow is stronger than Batman");

float playerSpeed = 1.2f;
float newPlayerSpeed = SetSpeed(2.5f);

CompareSpeed(newPlayerSpeed, playerSpeed);

float SetSpeed(float Speed)
{
    Console.WriteLine("The Player Speed: " + playerSpeed);
    Console.WriteLine("The New Player Speed is: " + Speed);

    return Speed;
}

void CompareSpeed(float New, float Old)
    {
    if (New > Old)
        Console.WriteLine("The Larger speed is the newer one: " + New);
    else if (New < Old)
        Console.WriteLine("The Larger speed is the older one: " + Old);

    else
        Console.WriteLine("They are equal: " + New + " = " + Old);
    }