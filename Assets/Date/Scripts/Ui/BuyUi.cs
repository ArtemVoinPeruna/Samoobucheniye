using Core.Rewards;
using UnityEngine;

namespace UI.RewardUIs
{
    public class BuyUi : MonoBehaviour
    {
        [field: SerializeField] private RewardView _rewardView;

        private void ButtonBuyClick()
        {
            _rewardView.RewardLineProd.CreateNewReward();
        }

    }
}
