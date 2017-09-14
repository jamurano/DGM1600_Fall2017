using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {
	public int valueOne;

	public int valueTwo;

	public int valueThree;

	public int valueFour;

	private int result;

	// Use this for initialization
	void Start () {
		DoMath();

	}
	
	void DoMath (){
		
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo + " = " + result);

		result = valueOne * valueTwo;
		print(valueOne + " x " + valueTwo + " = " + result);

		result = valueOne - valueTwo;
		print(valueOne + " - " + valueTwo + " = " + result);

		result = valueOne / valueTwo;
		print(valueOne + " / " + valueTwo + " = " + result);

		result = valueThree + valueTwo;
		print(valueThree + " + " + valueTwo + " = " + result);

		result = valueOne - valueFour;
		print(valueOne + " - " + valueFour +  " = " + result);

		result = valueFour * valueThree;
		print(valueFour + " * " + valueThree + " = " + result);

		result = valueThree / valueOne;
		print(valueThree + " / " + valueOne + " = " + result);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
