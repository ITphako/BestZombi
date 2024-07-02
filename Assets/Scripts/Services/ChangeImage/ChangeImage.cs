
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{ 
        [SerializeField] private MainRender[] _mobRenders;
        public bool _isReadyRandom;
        public MobRender MainMob;
        public int RandomIdMob;
        public int SaveIdMob;
        

        private void Update()
        {
             if(_isReadyRandom == true)
             {
            SaveIdMob = RandomIdMob;
            RandomIdMob = Random.Range(1,4);
            if(RandomIdMob != SaveIdMob)
            {
              _isReadyRandom = false;
            }
             }
        }

        public void RandomSkin()
        {
            for(int i = 0; i < _mobRenders.Length; i++)
            {
             if(_mobRenders[i].IdMob == RandomIdMob && SaveIdMob != RandomIdMob)
                {
           ChangeMobSkin(MainMob, _mobRenders[i].MobRender);  
            _isReadyRandom = true;
                }
            }
        }

        public void ChangeMobSkin(MobRender mobMain , MobRender mobSkin)
        {
            mobMain.Head.sprite = mobSkin.Head.sprite;
            mobMain.Body.sprite = mobSkin.Body.sprite;
            mobMain.LeftHand.sprite = mobSkin.LeftHand.sprite;
            mobMain.RightHand.sprite = mobSkin.RightHand.sprite;
            mobMain.LeftLag.sprite = mobSkin.LeftLag.sprite;
            mobMain.RightLag.sprite = mobSkin.RightLag.sprite;
            mobMain.DeffectLeft.sprite = mobSkin.DeffectLeft.sprite;
            mobMain.DeffectRight.sprite = mobSkin.DeffectRight.sprite;
        }
        
}
