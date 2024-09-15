using UnityEngine;
using Core.Rewards;
using UnityEngine.UI;

namespace UI.RewardUIs
{
    public class CollectUI : MonoBehaviour
    {
        [field: SerializeField] private RewardView _rewardView;
        [field: SerializeField] private Button _collectButton;

        private void Start()
        {
            if (_collectButton != null)
            {
                _collectButton.onClick.AddListener(OnCollectButtonClick);
            }
            else
            {
                Debug.LogError("Collect button is not assigned!");
            }
        }

        private void OnCollectButtonClick()
        {
            if (_rewardView != null && _rewardView.RewardLine != null)
            {
                _rewardView.RewardLine.CollectCoins();
            }
            else
            {
                Debug.LogError("RewardView or RewardLine is not assigned!");
            }
        }
    }
}
