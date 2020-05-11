//This is the C# script for a simple console game where the computer tries to guess
//a number that the user has selected between 1 and 1000
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hey there! Welcome to the Number Wizard!");
        Debug.Log("Now, I want you to think of a number, but don't tell me what it is.");
        Debug.Log("The highest number you can pick iss: " + max);
        Debug.Log("And the lowest number you can pick is: " + min);
        Debug.Log("So, let's get started. Tell me, is your number greater or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //The following cocde to detect if up arrow was pressed was found at https://docs.unity3d.com/ScriptReference/KeyCode.UpArrow.html
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("You selected higher.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess);
        }

        //Detect when down key is pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("You selected lower.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess);
        }

        //Detect when enter/return key is pressed
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            
            Debug.Log("Boy am I smart?!");
        }
    }
}
