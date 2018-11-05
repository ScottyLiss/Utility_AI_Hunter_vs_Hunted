using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : UtilityScript
{

    public override void Start()
    {
        base.Breed();
    }


    // Method 1: Sleep
    // Stay in position to gain rest
    // Arrival 


    // Method 2: Search for food
    // Once at food, eat food
    // Mixture of Arrival / Wander

    // Method 3: Wander around 
    // Use wander script

    // Method 4: Breed
    // Search for other AI and breed
    // Use Arrival

    // Method 5: Run!
    // If hunter is within proximity 
    // Run away! (Use Flee)

    // Method 6: Produce Offspring
    // Timer on when to spawn offspring
}
