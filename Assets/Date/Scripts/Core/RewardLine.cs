using UnityEngine;

namespace Core.Rewards
{
    public class RewardLine : MonoBehaviour
    {
        [field: SerializeField] private RewardView _rewardView;
        [field: SerializeField] private MoneyBox _moneyBox;
        [field: SerializeField] private int CapacityBaseLimit;
        [field: SerializeField] private int InitalCostBuy;

        private float _limitMultiply = 1.1f;

        public int Capacity => Mathf.RoundToInt(CapacityBaseLimit * Mathf.Pow(_limitMultiply, Lvl - 1));
        public int CostBuy => Mathf.RoundToInt(InitalCostBuy * Mathf.Pow(_limitMultiply, Lvl - 1));
        public int Lvl { get; private set; }
        public int Fill { get; private set; }


        private void Start()
        {
            InvokeRepeating(nameof(AddCoins), 1f, 1f);
        }

        private void AddCoins()
        {
           if (Fill < Capacity)
            {
                Mathf.RoundToInt(Fill);
            }
        }

        public void CollectCoins()
        {
            _moneyBox.CurrencyAmount += Fill;

            Fill = 0;
        }

        public void Upgrade()
        {
            Lvl++; 
        }

    }
}