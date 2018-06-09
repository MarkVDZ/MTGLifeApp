using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData
{
    public string playerName;
}

public class Main : MonoBehaviour {

    public List<PlayerData> players;
    public Transform contentPanel;
    public GameObject prefab;
    //public GameObject playerButton;
    //public GameObject removePlayerPanel;

	// Use this for initialization
	void Start () {
		
	}

    public void AddPlayer()
    {
        PlayerData data = new PlayerData();
        players.Add(data);
        data.playerName = "Player " + players.Count;
        GameObject newButton = GameObject.Instantiate(prefab);
        newButton.transform.SetParent(contentPanel);

        PlayerButton playerButton = newButton.GetComponent<PlayerButton>();
        playerButton.Setup(data, this);

        //old stuff
        //Player newPlayer = new Player();
        //newPlayer.name = "Player " + players.Count;
        //GameObject newButton = Instantiate(playerButton);
        //newButton.transform.SetParent(removePlayerPanel.transform);
        //newButton.GetComponent<Text>().text = newPlayer.name;
        //players.Add(newPlayer);
        //print(players.Count);
        //print(newButton.GetComponent<Player>().name);
    }

    public void RemovePlayer(PlayerData playerToRemove)
    {
        for(int i = players.Count - 1; i >= 0; i--)
        {
            print("IN the loop");
            if (players[i] == playerToRemove)
            {
                print("Attempt to remove button");
                players.RemoveAt(i);
                
            }
        }
       
    }
}
