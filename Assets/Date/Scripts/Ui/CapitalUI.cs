using Core.Rewards;
using TMPro;
using UnityEngine;

namespace UI.RewardUIs
{
    public class CapitalUI : MonoBehaviour
    {
        [field: SerializeField] private TMP_Text _currencyText;
        [field: SerializeField] private RewardView _rewardView;

        private void OnEnable()
        {
            _rewardView.RewardLine.MoneyBox.CurrencyChanged += OnCurrencyChanged;
        }

        private void OnDisable()
        {
            _rewardView.RewardLine.MoneyBox.CurrencyChanged -= OnCurrencyChanged;
        }


        private void OnCurrencyChanged()
        {
            if (_currencyText != null)
            {
                _currencyText.text = _rewardView.RewardLine.MoneyBox.CurrencyAmount.ToString();
            }
        }
    }
}
