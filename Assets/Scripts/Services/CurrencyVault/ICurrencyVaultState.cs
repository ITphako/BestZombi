using System;

    public interface ICurrencyVaultState
    {
        double CurrentCountDouble { get; set;}
        double MaxValueDouble { get; set;}
        double MaxValueTwo { get; set;}
        double MaxValueThree { get; set;}
        double MaxValueFo { get; set;}
        double MaxValueFive { get; set;}
        double MaxValueSix { get; set;}
        

        event Action< double> OnChange;
        event Action<double,double> OnChanged;
        event Action<double,double> OnChangedTwo;
        event Action<double,double> OnChangedThree;
        event Action<double,double> OnChangedFo;
        event Action<double,double> OnChangedFive;
        event Action<double,double> OnChangedSix;
    }