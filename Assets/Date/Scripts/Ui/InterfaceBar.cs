using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Rewards;
using TMPro;

namespace UI.RewardUIs
{
    public class InterfaceBar : MonoBehaviour
    {
        [field: SerializeField] private TMP_Text _text;
        [field: SerializeField] private RewardView _rewardView;
        private void OnEnable() 
            {
                _rewardView.BarChanged += OnBarChange;
            }

            private void OnDisable() 
            {
                _rewardView.BarChanged += OnBarChange;
            }
        public void OnBarChange(RewardLine bar)
        {
          
        }    
    }
}
