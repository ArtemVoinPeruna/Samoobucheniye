using UnityEngine;

[CreateAssetMenu(fileName = "MoneyBox", menuName = "ScriptableObjects/MoneyBox", order = 1)]
public class MoneyBox : ScriptableObject
{
    private int _currencyAmount;

    public int CurrencyAmount
    {
        get { return _currencyAmount; }
        private set { _currencyAmount = value; }
    }

    public static MoneyBox Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<MoneyBox>("MoneyBox");
            }
            return _instance;
        }
    }
    private static MoneyBox _instance;

    public void AddCurrency(int amount)
    {
        CurrencyAmount += amount;
        MoneyBoxSave.Instance.SaveCurrency(CurrencyAmount);
    }

    public bool SpendCurrency(int amount)
    {
        if (CurrencyAmount >= amount)
        {
            CurrencyAmount -= amount;
            MoneyBoxSave.Instance.SaveCurrency(CurrencyAmount);
            return true;
        }
        return false;
    }
}
