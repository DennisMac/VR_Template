﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    public bool gameTimerIO = false;
    public float gameTime = 120.0f;

    public bool exitRockIO = false;
    public bool vocalGuide = false;
    public bool soloGuide = false;

    // Use this for initialization
    void Start () {
        //PlayerPrefs.SetInt("with or without sound", 20);//with or without sound

        if (gameTimerIO == true) {
            this.gameObject.GetComponent<Canvas>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update () {
        if (gameTimerIO == true) {
            TimeCon();
        }
    }

    void Tick() {

    }

    void TimeCon() {
        gameTime -= Time.deltaTime;
        if (gameTime <= 0.0f) {
            this.gameObject.GetComponent<Canvas>().enabled = true;
        }
    }

    void OnMouseDown() {

        if (exitRockIO == true) {
            Application.Quit();
            Debug.Log("Exiting");
        }

        if (vocalGuide == true) {
            SceneManager.LoadScene("VocalGuideLeadLevel", LoadSceneMode.Single);
            Debug.Log("VocalGuideLeadLevel Loading");
        }

        if (soloGuide == true) {
            SceneManager.LoadScene("SoloGuideLeadLead", LoadSceneMode.Single);
            Debug.Log("SoloGuideLeadLead Loading");
        }
    }

    //vocal guide lead, solo guide lead
    public void VocalG() {
        SceneManager.LoadScene("VocalGuideLeadLevel", LoadSceneMode.Single);
        Debug.Log("VocalGuideLeadLevel Loading");
    }

    public void SoloG() {
        SceneManager.LoadScene("SoloGuideLeadLead", LoadSceneMode.Single);
        Debug.Log("SoloGuideLeadLead Loading");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exiting");
    }
}
