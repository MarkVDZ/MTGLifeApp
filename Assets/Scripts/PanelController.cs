using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PanelController : MonoBehaviour, IPointerClickHandler
{

    public GameObject extraMenu;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        extraMenu.SetActive(!extraMenu.activeSelf);
    }

}
