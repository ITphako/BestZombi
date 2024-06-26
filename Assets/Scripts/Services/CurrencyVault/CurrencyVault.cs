 ﻿using System;
using UnityEngine;
 
  public class CurrencyVault : ICurrencyVault, ICurrencyVaultState
    {
        public event Action< double> OnChange;
        public event Action<double,double> OnChanged;
        public event Action<double,double> OnChangedTwo;
        public event Action<double,double> OnChangedThree;
        public event Action<double,double> OnChangedFo;
        public event Action<double,double> OnChangedFive;
        public event Action<double,double> OnChangedSix;

        public double CurrentCountDouble {get; set;}
        public double MaxValueDouble {get; set;}
        public double MaxValueTwo {get; set;}
        public double MaxValueThree {get; set;}
        public double MaxValueFo {get; set;}
        public double MaxValueFive {get; set;}
        public double MaxValueSix {get; set;}
        
         public void ChangeCurrency(double amount)
        {
           CurrentCountDouble += amount;

            OnChange?.Invoke( CurrentCountDouble);
            OnChanged?.Invoke(CurrentCountDouble,MaxValueDouble);
            OnChangedTwo?.Invoke(CurrentCountDouble,MaxValueTwo);
            OnChangedThree?.Invoke(CurrentCountDouble,MaxValueThree);
            OnChangedFo?.Invoke(CurrentCountDouble,MaxValueFo);
            OnChangedFive?.Invoke(CurrentCountDouble,MaxValueFive);
            OnChangedSix?.Invoke(CurrentCountDouble,MaxValueSix);
        }
    }