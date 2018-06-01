using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaCounterController : MonoBehaviour {

    public Text whiteManaText;
    public Text blueManaText;
    public Text redManaText;
    public Text greenManaText;
    public Text blackManaText;
    public Text colorlessManaText;
    public Text totalManaText;

    int totalWhiteMana;
    int totalBlueMana;
    int totalRedMana;
    int totalGreenMana;
    int totalBlackMana;
    int totalColorlessMana;
    int totalMana;

	// Use this for initialization
	void Start () {
		
	}
	

    private void UpdateTotal()
    {
        totalMana = totalBlackMana + totalBlueMana + totalColorlessMana + totalGreenMana + totalRedMana + totalWhiteMana;
        totalManaText.text = totalMana.ToString();
    }

    public void IncreaseMana(string color)
    {
        switch (color)
        {
            case "white":
                totalWhiteMana++;
                whiteManaText.text = totalWhiteMana.ToString();
                break;
            case "blue":
                totalBlueMana++;
                blueManaText.text = totalBlueMana.ToString();
                break;
            case "red":
                totalRedMana++;
                redManaText.text = totalRedMana.ToString();
                break;
            case "green":
                totalGreenMana++;
                greenManaText.text = totalGreenMana.ToString();
                break;
            case "black":
                totalBlackMana++;
                blackManaText.text = totalBlackMana.ToString();
                break;
            case "colorless":
                totalColorlessMana++;
                colorlessManaText.text = totalColorlessMana.ToString();
                break;
        }

        UpdateTotal();
    }

    public void DecreaseMana(string color)
    {
        switch (color)
        {
            case "white":
                totalWhiteMana--;
                whiteManaText.text = totalWhiteMana.ToString();
                break;
            case "blue":
                totalBlueMana--;
                blueManaText.text = totalBlueMana.ToString();
                break;
            case "red":
                totalRedMana--;
                redManaText.text = totalRedMana.ToString();
                break;
            case "green":
                totalGreenMana--;
                greenManaText.text = totalGreenMana.ToString();
                break;
            case "black":
                totalBlackMana--;
                blackManaText.text = totalBlackMana.ToString();
                break;
            case "colorless":
                totalColorlessMana--;
                colorlessManaText.text = totalColorlessMana.ToString();
                break;
        }

        UpdateTotal();
    }

}
