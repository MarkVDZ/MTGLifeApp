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

    private void UpdateInfectTotal()
    {
        infectTotal.text = infect.ToString();
    }


    public void InfectUp(int amount)
    {
        switch (amount)
        {
            case 0:

                break;

            case 1:
                infect++;
                break;

            case 5:
                infect += 5;
                break;

        }
        UpdateInfectTotal();
    }

    public void InfectDown(int amount)
    {
        switch (amount)
        {
            case 0:

                break;

            case 1:
                infect--;
                break;

            case 5:
                infect -= 5;
                break;

        }
        UpdateInfectTotal();
    }
}
