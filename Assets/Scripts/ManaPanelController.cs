using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManaPanelController : MonoBehaviour, IPointerClickHandler {

    public GameObject manaPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        print("FASDFSFFFFF");
        manaPanel.SetActive(!manaPanel.activeSelf);
    }
}
