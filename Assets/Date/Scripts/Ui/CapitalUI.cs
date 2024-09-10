using Core.Rewards;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.RewardUIs
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] private RewardView _rewardView;

        private void ButtonClick()
        {
            _rewardView.ProgressBar.MoneyBox.CurrencyChanged += OnCurrencyChanged;
        }

        private void OnCurrencyChanged()
        {

        }
    }
}
