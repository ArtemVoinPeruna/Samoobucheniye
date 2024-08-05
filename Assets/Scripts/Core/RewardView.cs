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

        public ProgressBar ProgressBar
        {
            get { return _progressBar; }
            private set { _progressBar = value; }
        }

        public RewardView Init(ProgressBar bar)
        {
            ProgressBar = bar;
            BarChanged?.Invoke(bar);
            return this;
        }

        public void UpdateProgressBar(float value)
        {
            if (ProgressBar != null)
            {
                ProgressBar.SetProgress(value);
            }
        }
    }
}