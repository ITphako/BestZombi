
using UnityEngine;
using TMPro;
// using YG;
using UnityEngine.SceneManagement;


public class Progress : MonoBehaviour
{
   public GameObject button;
   public GameObject text;


// private void OnEnable() => YandexGame.GetDataEvent += ActiveButton;


// private void OnDisable() => YandexGame.GetDataEvent -= ActiveButton;


private void ActiveButton()
{
   // YandexGame.GameReadyAPI();
   // YandexGame.StickyAdActivity(true);
          SceneManager.LoadScene( 1); 
}
}
