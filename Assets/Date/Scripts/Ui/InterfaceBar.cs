using UnityEngine;
using Core.Rewards;
using TMPro;
using UnityEngine.UI;

namespace UI.RewardUIs
{
    public class InterfaceBar : MonoBehaviour
    {
        [field: SerializeField] private TMP_Text _maxText;
        [field: SerializeField] private RewardView _rewardView;
        [field: SerializeField] private Image _fillView;

        private RewardLine _rewardLine;

        private void OnEnable()
        {
            if (_rewardView != null)
            {
                _rewardView.BarChanged += OnBarChange;

                if (_rewardView.RewardLine != null)
                {
                    _rewardLine = _rewardView.RewardLine;
                    _rewardLine.InterfaceBar += OnInterfBar;
                }
            }
            else
            {
                Debug.LogError("RewardView is not assigned!");
            }
        }

        private void OnDisable()
        {
            if (_rewardView != null)
            {
                _rewardView.BarChanged -= OnBarChange;

                if (_rewardView.RewardLine != null)
                {
                    _rewardView.RewardLine.InterfaceBar -= OnInterfBar;
                }
            }
        }

        public void OnBarChange(RewardLine bar)
        {
            if (_rewardLine != null)
            {
                _rewardLine.InterfaceBar -= OnInterfBar;
            }

            _rewardLine = bar;
            _rewardLine.InterfaceBar += OnInterfBar;

            InterfBarView();
        }

        public void OnInterfBar() => InterfBarView();

        public void InterfBarView()
        {
            if (_rewardLine != null && _maxText != null && _fillView != null)
            {
                _maxText.text = $"{_rewardLine.Fill} / {_rewardLine.Capacity}";
                _fillView.fillAmount = (float)_rewardLine.Fill / _rewardLine.Capacity;
            }
        }
    }
}
