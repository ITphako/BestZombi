
using UnityEngine;

public class HouseSence : MonoBehaviour
{
 [SerializeField] private GameObject _canvasHouse;
 [SerializeField] private GameObject _canvasStatic;
 [SerializeField] private GameObject _canvasDynamic;
 public Ease ease;

    public void OpenArena()
    {
        _canvasHouse.SetActive(false);
        _canvasStatic.SetActive(true); 
        _canvasDynamic.SetActive(true);
    }

     public void CloseArena()
    {
        _canvasHouse.SetActive(true);
        _canvasStatic.SetActive(false);
        _canvasDynamic.SetActive(false);
    }
}
