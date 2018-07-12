using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButton : MonoBehaviour {

    public Button button;
    public Text playerLabel;
    private PlayerData data;
    private Main main;

    // Use this for initialization
    void Start ()
    {
        button.onClick.AddListener(HandleClick);
	}
	
	public void Setup(PlayerData currentData, Main currentMain)
    {
        data = currentData;
        playerLabel.text = data.playerName;
        main = currentMain;
    }

    public void HandleClick()
    {
        //FindObjectOfType<Main>().RemovePlayer(data);
        main.RemovePlayer(data);
        Destroy(this.gameObject);
        print("Called remove on button click");
    }

}
