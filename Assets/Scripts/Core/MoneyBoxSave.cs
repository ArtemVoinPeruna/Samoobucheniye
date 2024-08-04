using UnityEngine;

[CreateAssetMenu(fileName = "MoneyBoxSave", menuName = "ScriptableObjects/MoneyBoxSave", order = 2)]
public class MoneyBoxSave : ScriptableObject
{
    public static MoneyBoxSave Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<MoneyBoxSave>("MoneyBoxSave");
            }
            return _instance;
        }
    }
    private static MoneyBoxSave _instance;

    public void SaveCurrency(int amount)
    {
        PlayerPrefs.SetInt("CurrencyAmount", amount);
        PlayerPrefs.Save();
    }

    public int LoadCurrency()
    {
        return PlayerPrefs.GetInt("CurrencyAmount", 0);
    }
}