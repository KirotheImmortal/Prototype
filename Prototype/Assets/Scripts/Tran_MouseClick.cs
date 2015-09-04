﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tran_MouseClick : MonoBehaviour {

    // I'm Tran!
    public Canvas Return_back;
    Vector3 camPos;
    void Start()
    {
        camPos = Camera.main.transform.position;
    }

    // zoom to the card when left mouse click
    void OnMouseDown()
    {
        // set camera to have same position as the card
        Camera.main.transform.position = transform.position;
        // set z-axis for camera to step back (You can change the value of z if needed)
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, -1.44f);

        // Button appear
        Return_back.gameObject.SetActive(true);
    }

    // use this for Button ClickOn() to return the camera back to the original position
    public void zoom_Back()
    {
        Camera.main.transform.position = camPos;
    }

}
