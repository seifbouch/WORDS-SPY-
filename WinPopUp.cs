using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPopUp : MonoBehaviour
{
    public GameObject winPopup;
    void Start()
    {
        winPopup.SetActive(false);

    }
    private void OnEnable()
    {
        GameEvents.OnBoardCompleted += ShowInPopUp ;
    }
    private void OnDisable()
    {
        GameEvents.OnBoardCompleted -= ShowInPopUp ;
    }
    private void ShowInPopUp()
    {
        winPopup.SetActive(true) ;
    }
    public void LoadNextLevel()
    {
        GameEvents.LoadNextLevelMethod();
    }

}
