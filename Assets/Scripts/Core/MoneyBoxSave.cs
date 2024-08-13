using UnityEngine;

[CreateAssetMenu(fileName = "MoneyBoxSave", menuName = "ScriptableObjects/MoneyBoxSave", order = 2)]
public class MoneyBoxSave : ScriptableObject
{
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