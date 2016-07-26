﻿using UnityEngine;
using System.Collections;

public class TestAudioControl : MonoBehaviour {
    AudioControl audioControl;
	// Use this for initialization
	void Start () {
        audioControl = GetComponent<AudioControl>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioControl.PlayHorn();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            audioControl.StopHorn();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            audioControl.PlayStartEngine();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            audioControl.PlayDrivingInside();
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            audioControl.StopDrivingInside();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            audioControl.PlaySkidding();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            audioControl.PlayTurn();
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            audioControl.StopTurn();
        }
	}
}
