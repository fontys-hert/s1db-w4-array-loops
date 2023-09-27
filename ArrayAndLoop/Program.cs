// The weapon Triangle!
// spear beats sword
// sword beats axe
// axe beats spear

string GetPlayerWeapon(string[] weaponsToChoose)
{
    Console.WriteLine("Welk wapen kies je:");
    
    for (int i = 0; i < weaponsToChoose.Length; i++)
    {
        string weapon = weaponsToChoose[i];
        Console.WriteLine($"{i + 1}: {weapon}");
    }

    string? playerInput = Console.ReadLine();
    if (!int.TryParse(playerInput, out int weaponIndex) || 
        !new int[] {1, 2, 3}.Contains(weaponIndex))
    {
        Console.WriteLine("Maak een fatsoenlijke keuze!");
        GetPlayerWeapon(weaponsToChoose);
    }

    string weaponChosen = weaponsToChoose[weaponIndex - 1];
    return weaponChosen;
}

string GetEnemyWeapon(string[] weaponToChoose)
{
    return "Maurice not impressed";
}

void DetermineWinner(string playerChoice, string enemyChoice)
{
}

string weapon1 = "sword";
string[] weapons = new[] { weapon1, "axe", "spear" };

string playerWeapon = GetPlayerWeapon(weapons);
string enemyWeapon = GetEnemyWeapon(weapons);
DetermineWinner(playerWeapon, enemyWeapon);