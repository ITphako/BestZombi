
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
        [SerializeField] private MobRender _ZombiYtoplenik;
        [SerializeField] private MobRender _Zombi;
        public MobRender MainMob;
        public int RandomIdMob;

        public void RandomSkin()
        {
            RandomIdMob = Random.Range(1,3);
            if(RandomIdMob == 1)
            {
           ChangeMobSkin(MainMob);
            }
              if(RandomIdMob == 2)
            {
           ChangeMobSkinTwo(MainMob);
            }
        }

        public void ChangeMobSkin(MobRender mob)
        {
            mob.Head.sprite = _ZombiYtoplenik.Head.sprite;
            mob.Body.sprite = _ZombiYtoplenik.Body.sprite;
            mob.LeftHand.sprite = _ZombiYtoplenik.LeftHand.sprite;
            mob.RightHand.sprite = _ZombiYtoplenik.RightHand.sprite;
            mob.LeftLag.sprite = _ZombiYtoplenik.LeftLag.sprite;
            mob.RightLag.sprite = _ZombiYtoplenik.RightLag.sprite;
            mob.DeffectLeft.sprite = _ZombiYtoplenik.DeffectLeft.sprite;
            mob.DeffectRight.sprite = _ZombiYtoplenik.DeffectRight.sprite;
        }

        public void ChangeMobSkinTwo(MobRender mob)
        {
            mob.Head.sprite = _Zombi.Head.sprite;
            mob.Body.sprite = _Zombi.Body.sprite;
            mob.LeftHand.sprite = _Zombi.LeftHand.sprite;
            mob.RightHand.sprite = _Zombi.RightHand.sprite;
            mob.LeftLag.sprite = _Zombi.LeftLag.sprite;
            mob.RightLag.sprite = _Zombi.RightLag.sprite;
            mob.DeffectLeft.sprite = _Zombi.DeffectLeft.sprite;
            mob.DeffectRight.sprite = _Zombi.DeffectRight.sprite;
        }

}
