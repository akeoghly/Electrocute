using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_To_Level_Three : MonoBehaviour
{
    public string Third_Scene;


    public void NextScene()
    {
        SceneManager.LoadScene(Third_Scene);
    }
}