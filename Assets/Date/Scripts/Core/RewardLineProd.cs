using UnityEngine;
using System.Collections.Generic;

namespace Core.Rewards
{
    public class RewardLineProd : MonoBehaviour
    {
        [SerializeField] private List<RewardLine> _rewards;
        [SerializeField] private RewardLine _rewardPrefab;

        private int _priceBar;


        public RewardLineView _logic_PREFAB;
        public delegate void RewardChangedDelegate(RewardLine reward);
        public event RewardChangedDelegate RewardChanged;

        private void Start()
        {
            foreach (var reward in _rewards)
            {
                
            }
        }


        public void CreateNewReward()
        {
            RewardLine newReward = Instantiate(_rewardPrefab, transform);

            _priceBar += 1000;
        }
    }
}