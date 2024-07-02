
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class WeaponView : MonoBehaviour, IWeaponView
{
    [SerializeField] private TMP_Text _price;
    [SerializeField] private TMP_Text _power;
    [SerializeField] private GameObject _image;
    [SerializeField] private string _numberText = "+";
    private double _priceWeaponDobule;
    private double _powerWeaponDobule;

    public Weapon _weapon;

    public event UnityAction<Weapon, WeaponView> SellButtonClick;

    public void Render(Weapon weapon, GameObject image)
    {
        _image = image;
        _weapon = weapon;
        _price.text = _numberText + weapon.PriceDobule.ToString();
        _power.text = _numberText + weapon.PowerDobule.ToString();
        _price.text = _numberText + ShortScaleString.parseDouble(weapon.PriceDobule, 1, 100000, true).ToString();
        _power.text = _numberText + ShortScaleString.parseDouble( weapon.PowerDobule, 1, 100000, true).ToString();
    } 
    
    public void Render(Weapon weapon)
    {
        _weapon = weapon;
        _price.text =_numberText + weapon.PriceDobule.ToString();
        _power.text = _numberText + weapon.PowerDobule.ToString();
        _price.text = _numberText +ShortScaleString.parseDouble(weapon.PriceDobule, 1, 100000, true).ToString();
        _power.text = _numberText +ShortScaleString.parseDouble( weapon.PowerDobule, 1, 100000, true).ToString();
    }

    private void OnButtonClick()
    {
        SellButtonClick?.Invoke(_weapon, this);

    }

    public double GetWeaponPriceDouble()
    {
       _priceWeaponDobule = _weapon.PriceDobule;

        return _priceWeaponDobule;
    }

    public double GetWeaponPowerDouble()
    {
       _powerWeaponDobule = _weapon.PowerDobule;

        return _powerWeaponDobule;
    }
}
