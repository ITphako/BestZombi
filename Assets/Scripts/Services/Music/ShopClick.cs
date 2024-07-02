
using UnityEngine;

public class ShopClick : MonoBehaviour
{
     [SerializeField] private AudioSource _musicSource;

     public void PlayMusic()
   {
     _musicSource.Play();
   }

}
