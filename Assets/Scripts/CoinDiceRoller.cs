using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDiceRoller : MonoBehaviour {

    public Text rollResultText;
    public int result;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Roll(string type)
    {
        switch (type)
        {
            case "coin":
                result = Random.Range(0, 2);
                if (result == 0) {

                    rollResultText.text = "heads"; 
                }
                else
                {
                    rollResultText.text = "tails";
                }  
                break;
            case "4":
                result = Random.Range(1, 4);
                rollResultText.text = result.ToString();
                break;
            case "6":
                result = Random.Range(1, 7);
                rollResultText.text = result.ToString();
                break;
            case "8":
                result = Random.Range(1, 9);
                rollResultText.text = result.ToString();
                break;
            case "10":
                result = Random.Range(1, 11);
                rollResultText.text = result.ToString();
                break;
            case "12":
                result = Random.Range(1, 13);
                rollResultText.text = result.ToString();
                break;
            case "20":
                result = Random.Range(1, 21);
                rollResultText.text = result.ToString();
                break;
            case "100":
                result = Random.Range(1, 101);
                rollResultText.text = result.ToString();
                break;
        }
        //result = Random.Range(1, 6);
        //rollResultText.text = result.ToString();
    }

}
