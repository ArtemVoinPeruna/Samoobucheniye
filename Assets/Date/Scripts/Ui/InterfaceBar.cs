using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Rewards;
using TMPro;

namespace UI.RewardUIs
{
    public class InterfaceBar : MonoBehaviour
    {
        [field: SerializeField] private TMP_Text _maxText;
        [field: SerializeField] private TMP_Text _currentText;
        [field: SerializeField] private RewardView _rewardView;
        private void OnEnable() 
        {
            _rewardView.BarChanged += OnBarChange;
            _rewardView.RewardLine.InterfaceBar += OnInterfBar;
        }

        private void OnDisable() 
        {
            _rewardView.BarChanged -= OnBarChange;
            _rewardView.RewardLine.InterfaceBar -= OnInterfBar;
        }

        public void OnBarChange(RewardLine bar) => InterfBarView();

        public void OnInterfBar() => InterfBarView();

        public void InterfBarView()
        {
            _maxText.text = _rewardView.RewardLine.;
            _currentText.text = _rewardView.
        }
    }
}
