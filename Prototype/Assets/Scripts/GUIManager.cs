//Dylan Guidry
//August 3, 2015
//GUIManager script
//Hold informations for buttons and other objects that are displayed to the screen
//That are not required to have special actions to make them execute when called apon

using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour
{
    public GameObject handCards;
    public GameObject cardDeck;
    public GameObject levelLoader;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnChange()
    {
        /*
            calls a turn transition function from another class
        */
    }
    public void sceneChange(string name)
    {
        Application.LoadLevel(name);
        /*
            Will use a function of the level loader class to load different scenes when 
            a button is clicks
        */
    }

    public void closeGAme()
    {
        Application.Quit();
        /*
            closes the application
        */
    }
}