using TMPro;
using UnityEngine;

namespace UI.RewardUIs
{
    public class CapitalUI : MonoBehaviour
    {
        [field: SerializeField] private TMP_Text _currencyText;
        [field: SerializeField] private MoneyBox _moneyBox;

        private void OnEnable()
        {
            if (_moneyBox != null)
            {
                _moneyBox.CurrencyChanged += OnCurrencyChanged;
                UpdateCurrencyText();
            }
            else
            {
                Debug.LogError("MoneyBox is not assigned!");
            }
        }

        private void OnDisable()
        {
            if (_moneyBox != null)
            {
                _moneyBox.CurrencyChanged -= OnCurrencyChanged;
            }
        }

        private void OnCurrencyChanged()
        {
            UpdateCurrencyText();
        }

        private void UpdateCurrencyText()
        {
            if (_currencyText != null)
            {
                _currencyText.text = _moneyBox.CurrencyAmount.ToString();
            }
            else
            {
                Debug.LogError("CurrencyText is not assigned!");
            }
        }
    }
}
