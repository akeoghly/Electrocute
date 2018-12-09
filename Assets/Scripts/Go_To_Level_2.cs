using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_To_Level_2 : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Second_Level");
    }
}