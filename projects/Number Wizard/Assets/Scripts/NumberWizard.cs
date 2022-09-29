using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{

	[SerializeField] int max;
	[SerializeField] int min;
	[SerializeField] TextMeshProUGUI guessText;
	int guess;

	// Use this for initialization
	void Start()
	{
		StartGame();
	}

	void StartGame()
	{
		//guess = (max + min) / 2;
		//guessText.text = guess.ToString();
		NextGuess();
		//max = max + 1;

		/*Debug.Log("G'day mate, welcome to numba wiz-ud...");
		Debug.Log("Pick a number, don't tell me what it is...");
		Debug.Log("The highest number you can pick is: " + max);
		Debug.Log("The lowest number you can pick is: " + min);
		Debug.Log("Tell me if your number is higher or lower than: " + guess);
		Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");*/

	}

	public void OnePressHigher()
	{
		min = guess + 1;
		NextGuess();
	}

	public void OnePressLower()
	{
		max = guess - 1;
		NextGuess();
	}


	// Update is called once per frame
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			///Debug.Log("I am a genius!");
			StartGame();
		}
	}
	void NextGuess()
	{
		guess = Random.Range(min, max + 1);
		///Debug.Log("Is it higher or lower than..." + guess);
		guessText.text = guess.ToString();
	}
}
