using UnityEngine;

[CreateAssetMenu(fileName = "MoneyBox", menuName = "ScriptableObjects/MoneyBox", order = 50)]
public class MoneyBox : ScriptableObject
{
    private int _currencyAmount;

    public int CurrencyAmount
    {
        get 
        {
            return _currencyAmount; 
        }
        set 
        {
            _currencyAmount += value; 
        }
    }

    private static MoneyBox _instance;

    public void AddCurrency(int amount)
    {
        CurrencyAmount += amount;
    }
}
