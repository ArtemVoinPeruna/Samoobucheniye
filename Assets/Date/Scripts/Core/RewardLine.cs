using UnityEngine;

namespace Core.Rewards
{
    public class RewardLine : MonoBehaviour
    {
        [field: SerializeField] private RewardView _rewardView;
        [field: SerializeField] public MoneyBox MoneyBox;
        [field: SerializeField] private int CapacityBaseLimit;
        [field: SerializeField] private int InitalCostBuy;

        private float _limitMultiply = 1.1f;

        public int Capacity => Mathf.RoundToInt(CapacityBaseLimit * Mathf.Pow(_limitMultiply, Lvl - 1));
        public int CostBuy => Mathf.RoundToInt(InitalCostBuy * Mathf.Pow(_limitMultiply, Lvl - 1));
        public int Lvl { get; private set; }
        public int Fill { get; private set; }

        public delegate void InterfaceBarDelegate();
        public event InterfaceBarDelegate InterfaceBar;

        public delegate void LvlChangedDelegate();
        public event LvlChangedDelegate LvlChanged;


        private void Start()
        {
            InvokeRepeating(nameof(AddCoins), 1f, 1f);
        }

        private void AddCoins()
        {
           if (Fill < Capacity)
            {
                Fill++;
                InterfaceBar?.Invoke();
            }
        }

        public void CollectCoins()
        {
            MoneyBox.CurrencyAmount += Fill;

            Fill = 0;
        }

        public void Upgrade()
        {
            Lvl++;

            InterfaceBar?.Invoke();
        }

    }
}