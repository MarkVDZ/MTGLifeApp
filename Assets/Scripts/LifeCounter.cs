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

    private void UpdateLifeTotal()
    {
        lifeText.text = life.ToString();
    }

	public void LifeUp(int amount){
        switch (amount)
        {
            case 0:

                break;

            case 1:
                life++;
                break;

            case 5:
                life += 5;
                break;
            
        }
        UpdateLifeTotal();
	}

	public void LifeDown(int amount){
        switch (amount)
        {
            case 0:

                break;

            case 1:
                life--;
                break;

            case 5:
                life -= 5;
                break;

        }
        UpdateLifeTotal();
	}

}
