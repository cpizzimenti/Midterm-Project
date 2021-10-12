using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//library to access scene manager

public class menuscript : MonoBehaviour
{
   public void LoadLevel(string name)//function with string parameter, void is return type.
    {
        SceneManager.LoadScene(name); 
    }

    public void Quit()//function with no parameters. 
    {
        Application.Quit();
    }
}
