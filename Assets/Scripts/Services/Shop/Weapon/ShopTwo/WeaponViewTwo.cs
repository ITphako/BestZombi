using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class WeaponViewTwo : MonoBehaviour
{
    [SerializeField] private TMP_Text _price;
    [SerializeField] private TMP_Text _power;
    public string _numberText = "/c";
    
    private double _priceWeapon;
    private double _powerWeapon; 

    public Weapon _weapon;

    public event UnityAction<Weapon, WeaponViewTwo> SellButtonClick;

    public void Render(Weapon weapon)
    {
        _weapon = weapon;
        _price.text =  weapon.PriceDobule.ToString() + _numberText;
        _power.text =  weapon.PowerDobule.ToString() + _numberText;
        _price.text = ShortScaleString.parseDouble(weapon.PriceDobule, 1, 100000, true).ToString()+ _numberText;
        _power.text = ShortScaleString.parseDouble( weapon.PowerDobule, 1, 100000, true).ToString()+ _numberText;
    }

    private void OnButtonClick()
    { 
        SellButtonClick?.Invoke(_weapon, this);

    }

    public double GetWeaponPrice()
    {
       _priceWeapon = _weapon.PriceDobule;

        return _priceWeapon;
    }

    public double GetWeaponPower()
    {
       _powerWeapon = _weapon.PowerDobule;

        return _powerWeapon;
    }
}
