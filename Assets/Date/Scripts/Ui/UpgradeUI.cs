using Core.Rewards;
using UnityEngine;

namespace UI.RewardUIs
{
    public class UpgradeUI : MonoBehaviour
    {
        [SerializeField] private RewardView _rewardView;



        private void ButtonClick()
        {
            _rewardView.RewardLine.Upgrade();
        }
    }
}
