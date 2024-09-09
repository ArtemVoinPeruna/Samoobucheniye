using UnityEngine;
using UnityEngine.UIElements;

namespace Core.Rewards
{
    public class RewardView : MonoBehaviour
    {
        [SerializeField] private RewardLine _progressBar;

        public delegate void BarChangedDelegate(RewardLine bar);
        public event BarChangedDelegate BarChanged;

        public RewardView Init(RewardLine bar)
        {
            _progressBar = bar;
            BarChanged?.Invoke(bar);
            return this;
        }
    }
}