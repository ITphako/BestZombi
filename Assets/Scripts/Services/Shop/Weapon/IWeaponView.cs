
using UnityEngine;
public interface IWeaponView
{
    void Render(Weapon weapon, GameObject image);
    void Render(Weapon weapon);
    double GetWeaponPriceDouble();
    double GetWeaponPowerDouble();
}