using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManagement : MonoBehaviour
{
    public void playgame()
        {
            SceneManager.LoadScene("SelectCategory");
        }
    public void exit()
   {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Restart ()
    {
        SceneManager.LoadScene ( SceneManager.GetActiveScene().name) ;
    }
}
