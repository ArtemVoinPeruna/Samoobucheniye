using UnityEngine;
using Core.Rewards;
using TMPro;
using UnityEngine.UI;

namespace UI.RewardUIs
{
    public class InterfaceBar : MonoBehaviour
    {
        [field: SerializeField] private TMP_Text _maxText;
        [field: SerializeField] private TMP_Text _currentText;
        [field: SerializeField] private RewardView _rewardView;
        [field: SerializeField] private Image _fillView;

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
            _maxText.text = _rewardView.RewardLine.Capacity.ToString();
            _currentText.text = _rewardView.RewardLine.Fill.ToString();
            _fillView.fillAmount += _rewardView.RewardLine.Fill / _rewardView.RewardLine.Capacity;
        }
    }
}
