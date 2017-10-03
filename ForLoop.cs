using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//For Loops are the same thing as While Loops for the most part except you don't have to put your initial information before writing the code.

public class ForLoop : MonoBehaviour {
	public int bottles = 100;

	// Use this for initialization
	void Start () {
		// while(bottles > 0){
		// 	print(bottles + "of orange crush on the wall!");
		// 	bottles --;
		// }
		for(; bottles > 0; bottles --){
			print(bottles + "of orange crush on the wall!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
public class ForLoop2 : MonoBehaviour{
	void Start () {

	for(int soap = 20; soap > 0; soap --){
		print("There be soap");
	}
	}
}
public class ForLoop3 : MonoBehaviour{
	
	void Start (){
		for(int animals = 1000000; animals > 0; animals --){
			print("too many animals!");
		}
	}
}
public class ForLoop4 : MonoBehaviour{
	void Start(){

		for(int pencils = 0; pencils < 5; pencils ++){
			print("Give me pencils");
		}
	}
}
public class ForLoop5 : MonoBehaviour{
	void Start(){
		for(float health = 99.5f; health > 0; health --){
			print("Watch your health");
		}
	}
}
public class ForLoop6 : MonoBehaviour{
	void Start(){
		for(float carGas = 12.3f; carGas > 0; carGas --){
			print("Gas for your car");
		}
	}
}
public class ForLoop7 : MonoBehaviour{
	void Start(){
		for(int apples = 0; apples < 30; apples ++){
			print("Pick them apples");
		}
	}
}
public class ForLoop8 : MonoBehaviour{
	void Start(){
		for(int oranges = 50; oranges > 0; oranges --){
			print("Have some oranges");
		}
	}
}