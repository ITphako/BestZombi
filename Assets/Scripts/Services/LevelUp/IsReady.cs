
using UnityEngine;
using UnityEngine.UI;

public class IsReady : MonoBehaviour
{
    
    [SerializeField] private Slider Slider;
    public int score ;
    public float velctty = 0;
    private void Update()
    {
        float current = Mathf.Clamp(Slider.value, score, 100) ;
        Slider.value = current;
    }
}
