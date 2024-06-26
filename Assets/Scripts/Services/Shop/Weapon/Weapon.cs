using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private double _priceDobule;

    public double PriceDobule => _priceDobule;

    [SerializeField] private double _powerDobule;

    public double PowerDobule => _powerDobule;
}
