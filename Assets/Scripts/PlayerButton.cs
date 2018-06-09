using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButton : MonoBehaviour {

    public Button button;
    public Text playerLabel;

    // Use this for initialization
    void Start () {
		
	}
	
	public void Setup(PlayerData data)
    {
        playerLabel.text = data.playerName;
    }

}
