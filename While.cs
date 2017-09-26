using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {
    public int bottles = 99;

	// Use this for initialization
	void Start () {
        while(bottles > 0)
        {
            print(bottles + "bottles of beer on the wall!");
            bottles--;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
public class While2 : MonoBehaviour
{
    public int bottles = 0;

    private void Start()
    {
        while(bottles < 100)
        {
            print(bottles + "bottles of beer on the wall!");
            bottles++;
        }
    }

    private void Update()
    {

    }
}
public class While3 : MonoBehaviour
{
    public int soap = 12;

    private void Start()
    {
        while(soap > 0)
        {
            print(soap + "lots of soap");
            soap--;
        
        }
    }
}
public class While4 : MonoBehaviour
{
    public int candy = 0;

    private void Start()
    {
        while(candy < 1000)
        {
            print(candy + "Yay! Candy!");
            candy++;
        }
    }
}
public class While5 : MonoBehaviour
{
    public int candy = 1000;

    private void Start()
    {
        while (candy > 0)
        {
            print(candy + "All the candy");
            candy--;
        }
    }
}
public class While6 : MonoBehaviour
{
    public int soap = 0;

    private void Start()
    {
        while(soap < 12)
        {
            print(soap + "Soap");
            soap ++;
        }
    }
}
public class While7 : MonoBehaviour
{
    public int bugs = 5;

    private void Start()
    {
        while(bugs > 0)
        {
            print(bugs + "Ewww!");
            bugs++;
        }
    }
}
public class While8 : MonoBehaviour
{
    public int bugs = 0;

    private void Start()
    {
        while(bugs < 5)
        {
            print(bugs + "Ewwwww");
            bugs--;
        }
    }
}
// Whiles are used to be able to loop through numbers that you set with an int. They can count up or down until it hits the number you are seeking. But, loops can be dangerous because sometimes it can be infinite which will crash the system.