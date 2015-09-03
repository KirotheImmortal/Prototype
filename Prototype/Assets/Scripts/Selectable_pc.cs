using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems; // for point enter and exit

public class Selectable_pc : MonoBehaviour
{
    private bool hover;
    public float time  = 3.0f;
    public float delayt = 0.0f;
    Vector3 mouse;


    void OnMouseEnter()
    {
        // putting your mouse onto a card will move it's y axis by 2
        //mouse = Input.mousePosition;
            transform.Translate(0, 2, 0);
            Debug.Log("Name: " + gameObject.name);
    }

    void OnMouseExit()
    {
        // As the mouse is moved off the card, it will decrease in it's y-axis by 2
        //if (Input.mousePosition != mouse)

            transform.Translate(0, -2, 0);
            Debug.Log("Name: " + gameObject.name);
        

        //else if (Input.mousePosition != mouse)
        //{
        //    transform.Translate(0, -2, 0);
        //    Debug.Log("Name: " + gameObject.name);
        //}
        
    }
}
