string file = "game-sequence.txt";
string str = File.ReadAllText(file);
string[] interactions = str.Split(',');

int lives = 3;
int points = 5000;
int pointValue = 0;
bool hasLives = true;
int scoreMultiplier = 0;



for(int i = 0; i < interactions.Length; i++){
    string interaction = interactions[i];
    if(hasLives == false)
    {
        break;
    }
    Console.WriteLine(interactions[i]);
    switch (interaction)
    {
        case "Bird":
            pointValue = 10;
            points += pointValue;
            break;
            
        case "CrestedIbis":
            pointValue = 100;
            points += pointValue;
            break;
            
        case "GreatKiskudee":
            pointValue = 300;
            points += pointValue;
            break;
            
        case "RedCrossbill":
            pointValue = 500;
            points += pointValue;
            break;

        case "Red-neckedPhalarope":
            pointValue = 700;
            points += pointValue;
            break;

        case "EveningGrosbeak":
            pointValue = 1000;
            points += pointValue;
            break;

        case "GreaterPrairieChicken":
            pointValue = 2000;
            points += pointValue;
            break;

        case "IcelandGull":
            pointValue = 3000;
            points += pointValue;
            break;

        case "Orange-belliedParrot":
            pointValue = 5000;
            points += pointValue;
            break;

        case "VulnerableBirdHunter":
            pointValue = 200 * (int)Math.Pow(2, scoreMultiplier);
            points += pointValue;
            scoreMultiplier++;
            break;


        case "InvincibleBirdHunter":
            lives --;
            scoreMultiplier = 0;
            break;

        

    }
        if(lives == 0)
        {
            hasLives = false;
        }
        
        CheckForExtraLife(points, pointValue);
    
    
}
Console.WriteLine($"Your final score: {points}");
Console.WriteLine($"You had {lives} lives left");


void CheckForExtraLife(int score, int pointsGained){
    int beforeInteraction = score - pointsGained;
    if(beforeInteraction / 10000 != score / 10000){
        lives ++;
        Console.WriteLine("You just gained a life");
    }
}

