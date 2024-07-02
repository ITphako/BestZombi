
using UnityEngine;

public class Lock : MonoBehaviour
{
   [SerializeField] private int _idCount;

   public int GetId()
   {
      return _idCount;
   }
}
