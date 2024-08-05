using UnityEngine;
using System.Collections.Generic;

namespace Core.Rewards
{
    public class RewardLineProd : MonoBehaviour
    {
        [SerializeField] private List<RewardLine> _rewards = new List<RewardLine>();
        [SerializeField] private RewardLine _rewardPrefab; // Префаб RewardLine

        public delegate void RewardChangedDelegate(RewardLine reward);
        public event RewardChangedDelegate RewardChanged;

        private void Start()
        {
            foreach (var reward in _rewards)
            {
                RewardChanged?.Invoke(reward);
            }
        }

        public void AddReward(RewardLine reward)
        {
            _rewards.Add(reward);
            RewardChanged?.Invoke(reward);
        }

        public void RemoveReward(RewardLine reward)
        {
            if (_rewards.Contains(reward))
            {
                _rewards.Remove(reward);
                RewardChanged?.Invoke(reward);
            }
        }

        public void CreateNewReward()
        {
            RewardLine newReward = Instantiate(_rewardPrefab, transform);
            AddReward(newReward);
        }
    }
}