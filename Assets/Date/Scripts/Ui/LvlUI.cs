using Core.Rewards;
using TMPro;
using UnityEngine;

namespace UI.RewardUIs
{
    public class LvlUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _lvlText;
        [SerializeField] private RewardView _rewardView;

        private RewardLine _currentRewardLine;

        private void OnEnable()
        {
            if (_rewardView != null && _rewardView.RewardLine != null)
            {
                SubscribeToRewardLine(_rewardView.RewardLine);
            }

            _rewardView.BarChanged += OnBarChanged;
        }

        private void OnDisable()
        {
            if (_currentRewardLine != null)
            {
                _currentRewardLine.LvlChanged -= OnLvlChanged;
            }

            _rewardView.BarChanged -= OnBarChanged;
        }

        private void OnBarChanged(RewardLine newRewardLine)
        {
            if (_currentRewardLine != null)
            {
                _currentRewardLine.LvlChanged -= OnLvlChanged;
            }

            SubscribeToRewardLine(newRewardLine);
        }

        private void SubscribeToRewardLine(RewardLine rewardLine)
        {
            if (rewardLine != null)
            {
                _currentRewardLine = rewardLine;
                _currentRewardLine.LvlChanged += OnLvlChanged;
                OnLvlChanged();
            }
        }

        private void OnLvlChanged()
        {
            if (_lvlText != null && _currentRewardLine != null)
            {
                _lvlText.text = _currentRewardLine.Lvl.ToString();
            }
        }
    }
}
