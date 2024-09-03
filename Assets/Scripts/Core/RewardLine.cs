using UnityEngine;

namespace Core.Rewards
{
    public class RewardLine : MonoBehaviour
    {
        private int _coin = 0;
        private float _accumulationRate = 1f;
        [SerializeField] private RewardView _rewardView;

        public int Coins
        {
            get 
            {
                return _coin; 
            }
            set 
            { 
                if(_coin != 0)
                {
                    _coin = value; 
                }
                
            }
        }

        private void Start()
        {
            InvokeRepeating(nameof(AddCoins), 1f, 1f);
        }

        private void AddCoins()
        {
            Coins += Mathf.RoundToInt(_accumulationRate);
        }

        public void CollectCoins()
        {
            Coins = 0;
        }

        public void Upgrade()
        {
        }
    }
}