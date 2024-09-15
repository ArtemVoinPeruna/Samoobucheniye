using UnityEngine;

namespace Core.Rewards
{
    public class RewardView : MonoBehaviour
    {
        [field: SerializeField] public RewardLine RewardLine { get; private set; }

        public delegate void BarChangedDelegate(RewardLine bar);
        public event BarChangedDelegate BarChanged;

        public RewardView Init(RewardLine bar)
        {
            if (bar != null)
            {
                RewardLine = bar;
                BarChanged?.Invoke(bar);
            }
            else
            {
                Debug.LogError("Attempted to initialize with a null RewardLine.");
            }

            return this;
        }
    }
}
