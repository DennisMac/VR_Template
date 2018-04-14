using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMen : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Tick();
    }

    public void Tick()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.rotation * Vector3.forward, out hit))
        {
            if (Input.GetAxis("Fire1") > 0.5f || Input.GetAxis("Fire2") > 0.5f || Input.GetAxis("Fire3") > 0.5f)
            {
                switch (hit.collider.gameObject.tag)
                {
                    case "exit":
                    ExitButton();
                        break;
                    case "soloG":
                        SoloG();
                        break;
                    case "vocalG":
                        VocalG();
                        break;
            }
                
            }
        }
    }

    //vocal guide lead, solo guide lead
    public void VocalG()
    {
        SceneManager.LoadScene("VocalGuideLeadLevel", LoadSceneMode.Single);
        Debug.Log("VocalGuideLeadLevel Loading");
    }

    public void SoloG()
    {
        SceneManager.LoadScene("SoloGuideLeadLead", LoadSceneMode.Single);
        Debug.Log("SoloGuideLeadLead Loading");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exiting");
    }
}
