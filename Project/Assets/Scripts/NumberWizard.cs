using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int high_num;
	int low_num;
	int guess; 

    void NextGuess()
    {
        print("Is the number bigger or smaller than" + guess + "?");
        print("Press UP if number is BIGGER");
        print("Press DOWN if number is SMALLER");
        print("Press ENTER if number is GUESSED");
    }
	// Use this for initialization
	void Start ()
    {
        StartGame();
	}

    void StartGame()
    {

        high_num = 1000;
        low_num = 1;
        guess = 500;
        print("Welcome to the number wizard");
        Debug.Log("please choose a number from " + low_num + " to " + high_num + "");
        NextGuess();
    }
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("UP arrow pressed");
			low_num = guess;
			guess = ((high_num + low_num) / 2);
            NextGuess();


        } else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow pressed");
			high_num = guess;
			guess = ((high_num + low_num) / 2);
            NextGuess();
        } else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Enter arrow pressed");

			
			if (Input.GetKeyDown (KeyCode.Q)) {
				UnityEditor.EditorApplication.isPlaying = false;

			}

            else
                if(Input.GetKeyDown(KeyCode.P))
            {
                StartGame();
            }

	
		}



	}

}