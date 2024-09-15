using Core.Rewards;
using UnityEngine;

namespace UI.RewardUIs
{
    public class UpgradeUI : MonoBehaviour
    {
        [SerializeField] private RewardView _rewardView;

        public void ButtonClick()
        {
            if (_rewardView != null && _rewardView.RewardLine != null)
            {
                _rewardView.RewardLine.Upgrade();
            }
            else
            {
                Debug.LogError("RewardView or RewardLine is not assigned!");
            }
        }
    }
}
