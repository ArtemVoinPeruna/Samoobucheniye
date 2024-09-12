using UnityEngine;

namespace Core.Rewards
{
    public class RewardView : MonoBehaviour
    {
        [HideInInspector] public RewardLine RewardLine;
        public delegate void BarChangedDelegate(RewardLine bar);
        public event BarChangedDelegate BarChanged;

        [HideInInspector] public RewardLineProd RewardLineProd;

        public RewardView Init(RewardLine bar)
        {
            RewardLine = bar;
            BarChanged?.Invoke(bar);
            return this;
        }
    }
}