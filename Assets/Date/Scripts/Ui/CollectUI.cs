using UnityEngine;
using Core.Rewards;

namespace UI.RewardUIs
{
    public class CollectUI : MonoBehaviour
    {
        [field: SerializeField] private RewardView _rewardView;



        private void ButtonClick()
        {
            _rewardView.RewardLine.CollectCoins();
        }

    }
}

