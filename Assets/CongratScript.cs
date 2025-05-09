﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    private List<string> TextToDisplay;

    private float RotatingSpeed;
    private float TimeToNextText;

    private int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        TimeToNextText = 0.0f;
        CurrentText = 0;

        RotatingSpeed = 1.0f;

        TextToDisplay = new List<string>();
        TextToDisplay.Add("Congratulation");
        TextToDisplay.Add("All Errors Fixed");

        Text.text = TextToDisplay[0];

        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToNextText += Time.deltaTime;

        if (TimeToNextText > RotatingSpeed)
        {
            TimeToNextText = 0.0f;

            CurrentText++;
            if (CurrentText >= TextToDisplay.Count)
            {
                CurrentText = 0;
            }   


            Text.text = TextToDisplay[CurrentText];
        }
    }
}