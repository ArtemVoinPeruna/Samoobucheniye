using UnityEngine;
using System.Collections.Generic;

namespace Core.Rewards
{
    public class RewardLineProd : MonoBehaviour
    {
        [field: SerializeField] private Transform rewardViewParent; 
        private List<RewardLine> rewards = new List<RewardLine>(); 

        public int PriceBar { get; private set; } 
        [SerializeField] private RewardLine rewardLinePrefab; 

        public delegate void RewardCreatedDelegate(RewardLine reward, Transform rewardViewParent);
        public event RewardCreatedDelegate RewardCreated;


        // private void Start()
        // {
        //     foreach (var reward in rewards)
        //     {
        //     }
        // }

        public void CreateNewReward()
        {
            RewardLine newReward = Instantiate(rewardLinePrefab, transform);
            PriceBar += 1000;

            
            RewardCreated?.Invoke(newReward, rewardViewParent);
        }
    }
}
