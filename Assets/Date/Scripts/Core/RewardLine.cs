using UnityEngine;

namespace Core.Rewards
{
    public class RewardLine : MonoBehaviour
    {
        [field: SerializeField] public MoneyBox MoneyBox { get; private set; }
        [field: SerializeField] private int CapacityBaseLimit;
        [field: SerializeField] private int InitialCostUpgrade;

        private float _limitMultiplier = 1.1f;

        public int Capacity => Mathf.RoundToInt(CapacityBaseLimit * Mathf.Pow(_limitMultiplier, Lvl - 1));
        public int CostUpgrade => Mathf.RoundToInt(InitialCostUpgrade * Mathf.Pow(_limitMultiplier, Lvl - 1));
        public int Lvl { get; private set; } = 1;
        public int Fill { get; private set; }

        
        public delegate void InterfaceBarDelegate();
        public event InterfaceBarDelegate InterfaceBar;
        public event InterfaceBarDelegate LvlChanged;
        public event InterfaceBarDelegate CostChanged;

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
            InterfaceBar?.Invoke();
        }

        public void Upgrade()
        { 
            if (MoneyBox.CurrencyAmount >= CostUpgrade)
            {
                MoneyBox.CurrencyAmount -= CostUpgrade;
                Lvl++;
                
                InterfaceBar?.Invoke();
                LvlChanged?.Invoke();
                CostChanged?.Invoke();
            }
        }
    }
}
