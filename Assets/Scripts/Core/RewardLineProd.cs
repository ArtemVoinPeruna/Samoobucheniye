using UnityEngine;
using System.Collections.Generic;

namespace Core.Rewards
{
    public class RewardLineProd : MonoBehaviour
    {
        private RewardLineView _logic_PREFAB;
        [SerializeField] private List<RewardLine> _rewards;
        [SerializeField] private RewardLine _rewardPrefab;

        public delegate void RewardChangedDelegate(RewardLine reward);
        public event RewardChangedDelegate RewardChanged;

        private void Start()
        {
            foreach (var reward in _rewards)
            {
                RewardChanged?.Invoke(reward);
            }
        }

        public void CreateNewReward()
        {
            RewardLine newReward = Instantiate(_rewardPrefab, transform);
            //AddReward(newReward);
        }
    }
}