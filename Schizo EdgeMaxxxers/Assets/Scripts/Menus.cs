using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
     public int levelOne;

    void start()
    {

    }
    
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(levelOne);
    }

    public int levelTwo;

    public void OnSettingsButtonPressed()
    {
        SceneManager.LoadScene(levelTwo);
    }

    public int levelZero;

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(levelZero);
    }
}
