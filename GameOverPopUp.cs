using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPopUp : MonoBehaviour
{
    public GameObject gameOverpopUp ;
    public GameObject continueAfterAdsButton ;
    void Start()
    {
        continueAfterAdsButton.GetComponent<Button>().interactable = false ;
        gameOverpopUp.SetActive(false);
        GameEvents.OngameOver += ShowGameOverPopUp;

    }
    private void OnDisable()
    {
        GameEvents.OngameOver -= ShowGameOverPopUp;
    }
    private void ShowGameOverPopUp()
    {
        gameOverpopUp.SetActive(true);
        continueAfterAdsButton.GetComponent<Button>().interactable = false ;
    }
}
