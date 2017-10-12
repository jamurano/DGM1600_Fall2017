using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Foreach prints what is there.
// Lists is a way to list out two different types. So you can use strings and ints or any other combination. 

public class ForEachLists : MonoBehaviour {



	void Start () {
		List<FirstOrder> badguys = new List<FirstOrder>();

		badguys.Add(new FirstOrder("Snoke", 1000));
		badguys.Add(new FirstOrder("General Hux", 20));
		badguys.Add(new FirstOrder("Kylo Ren", 400));
		badguys.Add(new FirstOrder("Captain Phasma", 150));

		badguys.Sort();
		
		foreach(FirstOrder guy in badguys){
			print(guy.name +" " + guy.power);
		}
	}
}
public class ForEachLists2 : MonoBehaviour {



	void Start () {
		List<FirstOrder> goodguys = new List<FirstOrder>();

		goodguys.Add(new FirstOrder("Princess Leia", 5000));
		goodguys.Add(new FirstOrder("Luke Skylark", 600));
		goodguys.Add(new FirstOrder("Yoda", 1000000));
		goodguys.Add(new FirstOrder("Chewy", 50));

		goodguys.Sort();
		
		foreach(FirstOrder guy in goodguys){
			print(guy.name +" " + guy.power);
		}
	}
}

