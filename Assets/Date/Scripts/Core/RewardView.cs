using UnityEngine;

namespace Core.Rewards
{
    public class RewardView : MonoBehaviour
    {
        [HideInInspector] public RewardLine ProgressBar;
        public delegate void BarChangedDelegate(RewardLine bar);
        public event BarChangedDelegate BarChanged;

        public RewardView Init(RewardLine bar)
        {
            ProgressBar = bar;
            BarChanged?.Invoke(bar);
            return this;
        }
    }
}