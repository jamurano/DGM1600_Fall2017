using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Logical Operators are used to compare different variables. You can use || which is "or". This will compare both statements to determine which one is true. && is used to compare both statments, where both need to be true or both false. 
// You can also use ! as a way to say if this statement is false then do this. 
public class LogicalOp : MonoBehaviour {
	public string luke = "Jedi";

	public string vader = "Sith";

	public bool leia = true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";

	public int num1 =10;

	public float num2 = 10.5f;

	// Use this for initialization
	void Start () {
		if(luke == "Jedi" && vader == "Nanny"){

			print("Vaders yo Nanny!");
		}
		else if (luke == "Jawa" && vader == "Sith"){

			print("Utinni");
		}
		else if(luke == "Jedi" && vader == "Sith"){
			
			print("Noooooooooooo! That's not true... That's impossible");
		}
		else{
			 print("The end!");
		}
		if(leia){
			print("No, there is another.");
		}
		else if(!leia){
			print("Hurray! Now I can date Luke.");
		}
		else{
			print("Han fired first!");
		}
		if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
			print("Meeeza Evil Bad Bad Sith Lorda");
		}
		else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
			print("As you wish, my master");
		}
		else{
			print("Not the younglings!");
		}

		if(num1 == 10 && num2 == 10.5){
			print("Yes!");
		}
		else if (num1 == 10 && num2 == 10){
			print("Noooooooooo!");
		}
		else{
		print("Utinni");
	}
	}
	// Update is called once per frame
	void Update () {
		
	}
}

public class LogicalOp2 : MonoBehaviour{

	public string link = "Boy";

	public string zelda = "Girl";

	void Start (){

		if(link == "Boy" && zelda == "Girl"){
			print("Correct, you did it!");
		}
		else{
			print("You are incorrect sir!!");
		}
	}
}

public class LogicalOp3 : MonoBehaviour{

	public string mario = "Plumber";

	void Start (){

		if(mario == "Plumber"){
			print("It's a me, a Mario!");
		}
		else{
			print("What??!!");
		}
	}
}

public class LogicalOp4 : MonoBehaviour{

	public string toad = "Mushroom";

	public string frog = "Not Toad";

	void Start (){

		if(toad == "Mushroom" || frog == "Not Toad"){
			print("Well, yes. Technically true.");
		}
		else{
			print("Nothingness....");
		}
	}
}

public class LogicalOp5 : MonoBehaviour{

	public string spiders = "Gross";

	public string butterflies = "pretty";
	
	void Start(){

		if(spiders == "Gross" && butterflies == "pretty"){
			print("Yup, pretty true");
		}
		else{
			print("You are wrong again!");
		}
	}

}

public class LogicalOp6 : MonoBehaviour{

	public string hate = "No Beuno";

	public string love = "Super Duper";

	void Start(){

		if(hate == "No Bueno" && love == "Super Duper"){
			print("Yin and Yang");
		}

		else{
			print("You don't know nuuuuthing!!");
		}
	}
}

public class LogicalOp7 : MonoBehaviour{

	public string princessPeach = "Help!";

	void Start(){

		if(princessPeach == "Help!"){
			print("I'm in another castle!!");
		}

		else{
			print("Finally, you saved me!!");
		}
	}
}