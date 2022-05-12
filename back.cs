using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class back : MonoBehaviour
{
    public void back_home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
