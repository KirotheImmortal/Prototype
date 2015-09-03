//Dylan Guidry
//August 3, 2015
//GUIObjButtons script
/*
    Will be attached to objects that need a button placed on them to 
    perfomr actions. If you need help with implementing this just ask me
    and I'll walk you through how to do it.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIObjButtons : MonoBehaviour
{
    public bool isDisplay = false;
    //temporary checks to see what objects the button is on
    public bool isDeck; 
    public bool isHand;
    public bool isField;

	// Use this for initialization
	void Start ()
    {
        datButton.SetActive(false);
	    //sets the button to not active on game start so that it does not appear
	}
	
	// Update is called once per frame
	void Update ()
    {   if (isDisplay == true)
        {
            datButton.SetActive(true);
        }
        else
        {
            datButton.SetActive(false);
        }
        //checks if the isDisplay boolean is true or false and this will determine if
        //The button should be shown to the screen
	}

    public void buttonActions(string n)
    {
        print(n);
        /*
        function calls go in here for the actions that should be performed 
        when the button is pressed
        */
    }

    void OnMouseOver()
    {
        isDisplay = true; //when the mouse is over the object sets isDisplay to true
    }

    void OnMouseExit()
    {
        isDisplay = false; //when the mouse is no longer hoovering over the object
                           //we set isDisplay to false
    }

    public GameObject datButton; //gamebject refrence to the button associated with an function
                                 //we wish to execute

    
}
