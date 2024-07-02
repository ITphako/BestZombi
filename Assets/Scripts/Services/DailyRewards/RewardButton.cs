
using UnityEngine;

public class RewardButton : MonoBehaviour
{
     [SerializeField] private GameObject _panel;
      [SerializeField] private GameObject _camera;
      public bool IsOpen ;

    public void EnablePanel(GameObject gameObject)
    {
       gameObject.SetActive(true);
       _camera.SetActive(false);
       IsOpen = true;
    }

    public void ClosePanel(GameObject gameObject)
    {
       gameObject.SetActive(false);
       _camera.SetActive(true);
       
       IsOpen = false;
    }

    

}
