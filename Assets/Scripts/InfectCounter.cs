using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfectCounter : MonoBehaviour {

    public Text infectTotal;
    int infect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InfectUp()
    {
        infect++;
        infectTotal.text = infect.ToString();
    }

    public void InfectDown()
    {
        infect--;
        infectTotal.text = infect.ToString();
    }
}
