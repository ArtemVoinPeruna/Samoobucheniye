using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Core.Rewards
{
    public class RewardUIController : MonoBehaviour
    {
        [SerializeField] private Button _collectButton;
        [SerializeField] private Button _createNewRewardButton;
        [SerializeField] private Button _upgradeRewardButton;
        [SerializeField] private TMP_Text _coinText;
        [SerializeField] private RewardLineProd _rewardLineProd;
        [SerializeField] private RewardLine _selectedReward;

        private void Start()
        {
            _collectButton.onClick.AddListener(OnCollectButtonClick);
            _createNewRewardButton.onClick.AddListener(OnCreateNewRewardButtonClick);
            _upgradeRewardButton.onClick.AddListener(OnUpgradeRewardButtonClick);
            _rewardLineProd.RewardChanged += OnRewardChanged;
        }

        private void OnRewardChanged(RewardLine reward)
        {
            UpdateCoinText(reward.Coins);
        }

        private void OnCollectButtonClick()
        {
            foreach (var reward in _rewardLineProd._rewards)
            {
                reward.CollectCoins();
            }
        }

        private void OnCreateNewRewardButtonClick()
        {
            _rewardLineProd.CreateNewReward();
        }

        private void OnUpgradeRewardButtonClick()
        {
            if (_selectedReward != null)
            {
                _selectedReward.Upgrade();
            }
        }

        private void UpdateCoinText(int coins)
        {
            _coinText.text = $"Coins: {coins}";
        }

        private void OnDestroy()
        {
            _rewardLineProd.RewardChanged -= OnRewardChanged;
        }
    }
}