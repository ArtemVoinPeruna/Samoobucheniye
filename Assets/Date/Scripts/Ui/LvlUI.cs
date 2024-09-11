using Core.Rewards;
using TMPro;
using UnityEngine;

namespace UI.RewardUIs
{
    public class LvlUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _lvlText;
        [SerializeField] private RewardView _rewardView;

        private void OnEnable()
        {
            _rewardView.RewardLine.LvlChanged += OnLvlChanged;
        }

        private void OnDisable()
        {
            _rewardView.RewardLine.LvlChanged -= OnLvlChanged;
        }


        private void OnLvlChanged()
        {
            if (_lvlText != null)
            {
                _lvlText.text = _rewardView.RewardLine.Lvl.ToString();
            }
        }
    }
}
