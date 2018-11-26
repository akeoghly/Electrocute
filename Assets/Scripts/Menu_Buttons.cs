using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Buttons : MonoBehaviour {

    public GameObject Menu_Panel;
    public GameObject Level_Select_Panel;

	// Use this for initialization
	void Start () {
        Menu_Panel.SetActive(true);
        Level_Select_Panel.SetActive(false);
	}

    public void ShowLevelPanel()
    {
        Menu_Panel.SetActive(false);
        Level_Select_Panel.SetActive(true);
    }
    public void ShowMenuPanel()
    {
        Menu_Panel.SetActive(true);
        Level_Select_Panel.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
