using UnityEngine;

namespace Core.Rewards
{
    public class RewardLineView : MonoBehaviour
    {
        [field: SerializeField] private RewardLineProd _rewardLineProd;
        [field: SerializeField] private RewardView _rewardViewPrefab;

        private void OnEnable()
        {
            if (_rewardLineProd != null)
            {
                _rewardLineProd.RewardCreated += OnRewardCreated; 
            }
            else
            {
                Debug.LogError("RewardLineProd is not assigned!");
            }
        }

        private void OnDisable()
        {
            if (_rewardLineProd != null)
            {
                _rewardLineProd.RewardCreated -= OnRewardCreated;
            }
        }

        private void OnRewardCreated(RewardLine rewardLine, Transform rewardViewParent)
        {
            RewardView rewardObject = Instantiate(_rewardViewPrefab, rewardViewParent).Init(rewardLine);

            rewardObject.transform.SetAsFirstSibling();
        }
    }
}
