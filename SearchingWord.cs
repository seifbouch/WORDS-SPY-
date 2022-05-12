using System.Collections ; 
using System.Collections.Generic ; 
using UnityEngine ;
using UnityEngine.UI ;
public class SearchingWord : MonoBehaviour 
{
    public Text displayedText ; 
    public Image crossline ; 

    private string _word ; 

  void start() 
  {

  }
  private void OnEnable() 
    {
        GameEvents.OnCorrectWord += CorrectWord ; 
    }
  private void OnDisable()
    {
        GameEvents.OnCorrectWord -= CorrectWord ;  
    }
  public void SetWord(string word )
    {
    _word = word ; 
    displayedText.text = word ; 
    }
private void CorrectWord(string word , List<int> squareIndexes) 
    {
        if (word == _word)
        {
            crossline.gameObject.SetActive(true) ; 
        }
    }
}