using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityScript : MonoBehaviour
{

    // Method 1: Sleep
    // Stay in position to gain rest
    // Arrival 

    public virtual void Start()
    {
        Debug.Log("Starting!");
    }

    public virtual void Sleep()
    {

    }

    // Method 2: Search for food
    // Once at food, eat food
    // Mixture of Arrival / Wander

    public virtual void SearchAndEat()
    {

    }


    // Method 3: Wander around 
    // Use wander script

    public virtual void Wander()
    {

    }


    // Method 4: Breed
    // Search for other AI and breed
    // Use Arrival

    protected virtual void Breed()
    {
        Debug.Log("I should breed!");
    }

    // Method 5: Run!
    // If hunter is within proximity 
    // Run away! (Use Flee)

    public virtual void Run()
    {

    }

    // Method 6: Produce Offspring
    // Timer on when to spawn offspring
    public virtual void ProduceOffspring()
    {

    }
}
