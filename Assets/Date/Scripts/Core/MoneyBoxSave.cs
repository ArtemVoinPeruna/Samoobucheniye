using UnityEngine;

[CreateAssetMenu(fileName = "MoneyBoxSave", menuName = "ScriptableObjects/MoneyBoxSave", order = 50)]
public class MoneyBoxSave : ScriptableObject
{

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