using System;
using UnityEngine;

namespace Core.Rewards
{
    public class RewardLineView : MonoBehaviour
    {

        [field:SerializeField] private RewardView _rewardView_PREFAB;
        [field:SerializeField] private Transform _rewardViewParent; //
        public RewardLineView Initial(RewardLine bar)
        {
            RewardView RewardObject = Instantiate(_rewardView_PREFAB, _rewardViewParent);
            RewardObject.Init(bar);
            return this;
        }
    }
}

