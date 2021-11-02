using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{

    public void LoadLevel(string name)//function with string parameter, void is return type.
    {
        SceneManager.LoadScene(name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        LoadLevel("gameover");
    }

}
