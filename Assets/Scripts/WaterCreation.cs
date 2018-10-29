using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCreation : MonoBehaviour {


    public GameObject Water;

	// Use this for initialization
	void Start () {
        WaterCreator();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void WaterCreator()
    {
        Instantiate(Water);
    }
}
