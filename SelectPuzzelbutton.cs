using System.Collections ; 
using System.Collections.Generic ; 
using System.Net.Mime ;
using UnityEngine ; 
using UnityEngine.UI ;
using UnityEngine.SceneManagement ; 
public class SelectPuzzelbutton : MonoBehaviour 
{
 public gameData gameData ; 
 public GameLevelData levelData ;
 public Text categoryText ; 
 public Image progressBarFilling ; 
 private string gameSceneName ="gamePlay";
 private bool levelLocked ; 

 void Start () 
 {
     levelLocked = false ;
  var button = GetComponent<Button>() ; 
  button.onClick.AddListener(OnButtonClick) ; 
  button.interactable = true ; 
  UpdateButtonInformation();
  if ( levelLocked )
  {
      button.interactable = false ;
  }
  else
  {
      button.interactable = true ;
  }
 }
 void Update() 
 {

 } 
 private void UpdateButtonInformation()
 {
     var currentIndex = -1 ; 
     var totalBoards = 0 ;
     foreach ( var data in levelData.data)
     {
         if (data.categoryName == gameObject.name)
         {
            currentIndex = DataSaver.ReadCategoryCurrentIndexValues(gameObject.name);
            totalBoards = data.boardData.Count;
            if (levelData.data[0].categoryName == gameObject.name && currentIndex < 0 )
            {
                DataSaver.SaveCategoryData(levelData.data[0].categoryName,0);
                currentIndex = DataSaver.ReadCategoryCurrentIndexValues(gameObject.name);
                totalBoards = data.boardData.Count;
            }
         }
     }

    if ( currentIndex == -1)
    {
        levelLocked = true ;
    }
    categoryText.text = levelLocked ? string.Empty : (currentIndex.ToString() + "/" + totalBoards.ToString());
    progressBarFilling.fillAmount = ( currentIndex >0 && totalBoards >0 ) ? ((float)currentIndex/(float) totalBoards) : 0f ;

 }
 private void OnButtonClick() 
 {
    gameData.selectedCategoryName = gameObject.name ;     
    SceneManager.LoadScene(gameSceneName) ; 
 }


} 