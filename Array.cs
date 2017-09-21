using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

	public string[] heros = new string[6];

	void Start () {
	heros[0] = "Batman";
	heros[1] = "Superman";
	heros[2] = "Ironman";
	heros[3] = "Spiderman";
	heros[4] = "Black Widow";
	heros[5] = "Wonder Woman";

	print(heros[0]);
	}
}

public class ArrayTwo : MonoBehaviour {

	public string[] villians = new string[6];

	void Start () {
	villians[0] = "Joker";
	villians[1] = "Cat Woman";
	villians[2] = "Poison Ivy";
	villians[3] = "Ultron";
	villians[4] = "Two Face";
	villians[5] = "Venom";
	}
}

public class ArrayThree : MonoBehaviour {

	public string[] food = new string[6];

	void Start (){
		food[0] = "Chicken";
		food[1] = "Potato";
		food[2] = "Cake";
		food[3] = "Pie";
		food[4] = "Celery";
		food[5] = "Banana";
	
	}
}

public class ArrayFour : MonoBehaviour {

	public int[] money = new int[6];

	void Start () {
		money[0] = 1;
		money[1] = 5;
		money[2] = 10;
		money[3] = 20;
		money[4] = 50;
		money[5] = 100;
	}
}

public class ArrayFive : MonoBehaviour {

	public int[] racingLaps = new int[3];

	void Start () {
		racingLaps[0] = 1;
		racingLaps[1] = 3;
		racingLaps[2] = 5;
	}
}
	// An Array is a tool that allows you to make several variables that are non-changable. Unlike Variables, you can make more variable at a time and make a list or group of items. You can "retrieve" an object from the Array.
	// You can use an Array as an invetory.

