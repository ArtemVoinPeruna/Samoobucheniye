using UnityEngine;

[CreateAssetMenu(fileName = "MoneyBox", menuName = "ScriptableObjects/MoneyBox", order = 50)]
public class MoneyBox : ScriptableObject
{
    private int _currencyAmount;

    public delegate void CurrencyAmountChanged();
    public event CurrencyAmountChanged CurrencyChanged;

    public int CurrencyAmount
    {
        get 
        {
            return _currencyAmount; 
        }
        set
        {
            _currencyAmount += value;
            if (_currencyAmount < 0)
            {
                _currencyAmount = 0;
            } 
            
        }
    }

    private static MoneyBox _instance;

    public void AddCurrency(int amount)
    {
        CurrencyAmount += amount;
    }
}
