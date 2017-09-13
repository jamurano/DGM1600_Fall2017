using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour {

	public float coffeeTemperature = 85.0f;

	public float hotLimitTemperature = 70.0f;

	public float coldLimitTemperature = 40.0f;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();

		coffeeTemperature _ = Time.deltaTime * 5f;
	}

	void TemperatureTest ()
	{
		// If the coffee's temperature is greater than the hottest drinking temperature...
		if(coffeeTemperature > hotLimitTemperature)
		{
			// ... do this.
			print("Coffee is too hot.");
		}
		//If it isn't, but the temperature is less than the coldest drinking temperature...
		else if(coffeeTemperature < coldLimitTemperature)
		{
			// ... do this.
			print ("Coffee is too cold.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("Coffee is just right.");
		}
			
}
	public class exampleTwo : MonoBehaviour {

		void Start(){

			int temperature = 70;
			int coldTemperature = 45;

			if(temperature > 70){
				
				print("It's too hot!");
			}

			else if(temperature < 45){
				
				print ("It's too cold!");
			}
			else{
				print ("It's nice outside!");
			}
		}
	}
	public class exampleThree : MonoBehaviour{
		void start(){

			int bottledWater = 100;
			int halfBottledWater = 50;
			int emptyBottledWater = 0;

			if(bottledWater == 100){

				print ("It's full.");
			}

			else if(bottledWater = 50){
				print ("It's half full");
			}

			else if (halfBottledWater < 50){

				print ("It's almost gone.");
			}

					else if(bottledWater == 0){
				print ("It's empty.");
			}

			else{
				print ("I don't know");
			}
		}
	}

	public class exampleFour : MonoBehaviour{
		void Start()
		{

			bool catsAreCute = true;
			int temperature = 40;

			if(temperature >= 35 && catsAreCute){

				Debug.Log ("Both conditions are true.");
			}

			else(temperature >= 35 || catsAreCute){
				Debug.Log ("Only takes one of these conditions to be true.");
			}
		}
	}

	public class exampleFive : MonoBehaviour{
		void Start(){
			string me = "I can't think of anymore.";

			if(me == "I can't think of anymore"){

				print("Too many examples...");
			}

			else{

				print ("I Don't know.");
			}
		}
	}