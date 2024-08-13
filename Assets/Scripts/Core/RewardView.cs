using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Core.Rewards
{
    public class RewardView : MonoBehaviour
    {
        [SerializeField] private ProgressBar _progressBar;

        public delegate void BarChangedDelegate(ProgressBar bar);
        public event BarChangedDelegate BarChanged;

        public RewardView Init(ProgressBar bar)
        {
            _progressBar = bar;
            BarChanged?.Invoke(bar);
            return this;
        }
    }
}