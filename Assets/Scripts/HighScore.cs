﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

    static public int score = 1000;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighscore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TextMesh scoreGT = this.GetComponent<TextMesh>();
        scoreGT.text = "High Score: " + score;


        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
	}
}
