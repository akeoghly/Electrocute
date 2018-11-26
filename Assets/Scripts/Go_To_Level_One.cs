using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_To_Level_One : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("First_Level");
    }
}