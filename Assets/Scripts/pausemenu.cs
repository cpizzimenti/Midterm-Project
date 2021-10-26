using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{


    public GameObject pauseUI;

    bool isPaused = false;

    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }


    public void TogglePause()
    {
        if(isPaused==true)
        {
            //unpuase

            Time.timeScale = 1;
          
            //hides button
            pauseUI.SetActive(false);
            //when is paused is true, this line will set it to false
            isPaused = false;
        }
        else
        {
            //pause

            Time.timeScale = 0;
            
            //shows button
            pauseUI.SetActive(true);
            //when isPaused is false, this line will set it to true
            isPaused = true;
        }

       // isPaused = !isPaused;//this line does the same thing as in the if/else statment; sets isPaused to the opposite of what it is rn

    }
    public void Quit()
    {

        Application.Quit();

    }

}
