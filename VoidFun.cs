using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFun : MonoBehaviour {
	public int laserBlast;

	// Use this for initialization
	void Start () {
		DeathStar(laserBlast);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent){
		print("That's no moon, that's a space station!");

		print(vent);

		if(vent == 1){
			print("Porkin's misses the mark");
		}
		else if(vent == 2){
			print("Red leader misses!");
		}
		else{
			print("Death star blows up!");
		}

	}
}
public class VoidFun2 : MonoBehaviour {
	public int journey;
	void Start (){
		CandyMountian(journey);
	}

	void Update (){

	}
		void CandyMountian (int mountian){
			print("It's Candy Mountian, Charlie!");

			print(mountian);

			if(mountian == 1){
				print("We are on a bridge, Charlllliiiiieeee!!");

			}
			else if(mountian == 2){
				print("Candy Mountian song");
			}
			else{
				print("They took my freakin' kidney!");
			}

		}

	}

public class VoidFun3 : MonoBehaviour {
	
	void Start (){
		
	}

	void Update (){
	}
		void WelcomeToNightVale (int nightVale){
			print("Welcome to Night Vale...");

			print(nightVale);

			if(nightVale == 1){
				print("The angels all use the name Elizabeth, and opened up the forbidden dog park. Don't go to the dog park, don't even know about the dog park.");
			}
			else if(nightVale == 2){
				print("Hello listeners, today a cubscout finally reach the Eternal Scout. His cerimony brought creepy children that only killed 20 people. So, nothing to worry about.");
			}
			else{
				print("As always, good night Night Vale, good night.");
			}

		}
	}
// Void Functions is like a machine where you put in the information that you want to run through and it will go through your code to pick what correspondes to what you wrote.
