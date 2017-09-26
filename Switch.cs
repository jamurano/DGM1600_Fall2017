using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
    public string townCenter = "main";

	// Use this for initialization
	void Start () {
        switch (townCenter)
        {
            case "main":
                print("Welcome to Main Street!");
                break;
            case "blacksmith":
                print("The blacksmith grumbles as you pick through the sword bin");
                break;
            case "bakery":
                print("Mmmmm... Baked goodness!");
                break;
            case "Morgue":
                print("Peeeeeeeeeeyew! Dead things, yuck!");
                break;
            default:
                print("I don't know what you are talking about!");
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Switch2 : MonoBehaviour{
    public string foodMart = "Food Mart";

    void Start()
    {
        switch (foodMart)
        {
            case "Food Mart":
                print("Welcome!");
                break;
            case "Apple":
                print("Crunchy and juicy");
                break;
            case "Bread":
                print("Avast Ye!! Sword fights with bread loafs.");
                break;
            default:
                print("Get out of here!!");
                break;
        }
   
    }
}
public class Switch3 : MonoBehaviour
{
    public string plants = "Oooh, plants!";

    void Start()
    {
        switch (plants)
        {
            case "Plants":
                print("Some plants, party.");
                break;
            case "Cactus":
                print("Ouch!!");
                break;
            case "Roses":
                print("Pretty");
                break;
            default:
                print("No more plants");
                break;
        }
        
    }

}
public class Switch4 : MonoBehaviour
{
    public string heros = "Good";

    private void Start()
    {
        switch (heros)
        {
            case "Heros":
                print("Choose your character!!"):
                break;
            case "Super Woman":
                print("I'm Awesome and an Amazonian!");
                break;
            case "Batman":
                print("I am the NIGHT!!");
                break;
            case "Aquaman":
                print("I am lame");
                break;
            default:
                print("Failure!!");
                break;
        }
    }
}
public class Switch5 : MonoBehaviour
{
    public string villans = "Evil";
    private void Start()
    {
        switch (villans)
        {
            case "Villans":
                print("EEEEEEEEVVVVVVVIIIILLLL!!!!");
                break;
            case "Hades":
                print("Boom baby!");
                break;
            case "Joker":
                print("Why so serious?");
                break;
            default:
                print("Have a penguin");
                break;

        }
    }
}
public class Switch6 : MonoBehaviour
{
    public string colors = "Yay!";

    private void Start()
    {
        switch (colors)
        {
            case "Colors":
                print("There be colors");
                break;
            default:
                print("Sometimes there be no colors");
                break;
        }
    }
}
public class Switch7 : MonoBehaviour
{
    public string shoes = "Another object";

    private void Start()
    {
        switch (shoes)
        {
            case "Heels":
                print("Wow, it's like its a shoe");
                break;
            case "Tennis":
                print("This is also a shoe");
                break;
            default:
                print("surprise, i'm not a shoe");
                break;
        }
    }
}
public class Switch8 : MonoBehaviour
{
    public string teeth = "I don't know";

    private void Start()
    {
        case "Vampire":
            print("They're sharp");
            break;
        case "Human":
            print("Normal");
             break;
        default:
            print("What are these!!?")
            break;
    }
}
// Switches are used to list different variables. The code when in use will go through each string in your code until it is true. 