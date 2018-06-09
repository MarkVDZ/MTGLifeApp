using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CoinPanelController : MonoBehaviour, IPointerClickHandler
{

    public GameObject coinPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        coinPanel.SetActive(!coinPanel.activeSelf);
    }
}
