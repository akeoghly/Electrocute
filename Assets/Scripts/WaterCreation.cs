using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCreation : MonoBehaviour { 


public GameObject Water;
public int x;
public int BallSpawnNumber;

// Use this for initialization
void Start()
{
    //WaterCreator();

    StartCoroutine(WaterCreator());

}

// Update is called once per frame
void Update()
{

}
private IEnumerator WaterCreator()
{
    while (x == 1)
    {
        
        for (int i = 0; i < BallSpawnNumber; i++)
        {

            yield return new WaitForSeconds(0.0000000000005F);
            GameObject tempWater = Instantiate(Water);
            tempWater.GetComponent<Rigidbody2D>().AddTorque(0.1f);

        }
    }

}
   
}


