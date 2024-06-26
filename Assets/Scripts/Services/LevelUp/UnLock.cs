
using UnityEngine;
using System.Collections.Generic;

public class UnLock : MonoBehaviour,IInjectServices
{
    [SerializeField] private List<Lock> _objects;
    [SerializeField] private List<Lock> _objectsItem;
    [SerializeField] private Shop _shop;
    private ILevelUp _levelUp;
    

    public bool ready = false;

    public bool IsSave = false;
    public bool IsSaveTwo = false;
    public bool IsSaveThree = false; 
    public bool IsSaveFo = false;
    public bool IsSaveFive = false;
    public bool IsSaveSix = false;
    public bool IsSaveTwoSave = false;

    public void InjectServices(IServiceLocator serviceLocator)
    {
            _levelUp = serviceLocator.GetService<ILevelUp>();
    }

    private void Start()
    {
      if(IsSaveTwoSave == true)
           SaveGet();
    }

    private void Update()
    {
      if(ready == true)
      {
        for (int i =0; i < _objects.Count; i++)
       {
            if(_objects[i].GetId() == _shop._startNumber)
            {
              _objects[i].gameObject.SetActive(false);
              ready = false;
              if(_levelUp.GetCount() == 1)
                    IsSave = true;
                    if(_levelUp.GetCount() == 3)
                    IsSaveTwo = true;
                    if(_levelUp.GetCount() == 5)
                    IsSaveThree = true;
                    if(_levelUp.GetCount() == 7)
                    IsSaveFo = true;
                    if(_levelUp.GetCount() == 9)
                    IsSaveFive = true;
                    if(_levelUp.GetCount() == 11)
                    IsSaveSix = true;
            }
       }
      }
    }

     public bool IsReady()
  {
    return ready = true;
  }

  public void SaveGet()
  {
    if(IsSave == true)
    _objects[0].gameObject.SetActive(false);

    if(IsSaveTwo == true)
    _objects[2].gameObject.SetActive(false);
    
    if(IsSaveThree == true)
    _objects[4].gameObject.SetActive(false);
    
    if(IsSaveFo == true)
    _objects[6].gameObject.SetActive(false);
    
    if(IsSaveFive == true)
    _objects[8].gameObject.SetActive(false);

    if(IsSaveSix == true)
    _objects[10].gameObject.SetActive(false);
}
}
