using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour {

	public Text lifeText;
	int life = 20;

	// Use this for initialization
	void Start () {
		lifeText.text = life.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LifeUp(){
		life++;
		lifeText.text = life.ToString();
	}

	public void LifeDown(){
		life--;
		lifeText.text = life.ToString();
	}

}
