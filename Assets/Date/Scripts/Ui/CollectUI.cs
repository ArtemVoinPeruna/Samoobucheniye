using UnityEngine;
using Core.Rewards;

namespace UI.RewardUIs
{
    public class CollectUI : MonoBehaviour
    {
        [SerializeField] private RewardView _rewardView;

        private void ButtonClick()
        {
            _rewardView.ProgressBar.CollectCoins();
        }
    }
}

