using UnityEngine;

namespace Core.Rewards
{
    public class RewardLine : MonoBehaviour
    {
        private int _coin = 0;
        private float _accumulationRate = 1f; // Скорость накопления монет
        [SerializeField] private RewardView _rewardView;

        public int Coins
        {
            get { return _coin; }
            private set { _coin = value; }
        }

        private void Start()
        {
            InvokeRepeating(nameof(AddCoins), 1f, 1f);
        }

        private void AddCoins()
        {
            Coins += Mathf.RoundToInt(_accumulationRate);
            _rewardView.UpdateProgressBar(Coins);
            Debug.Log($"Накоплено монет: {Coins}");
        }

        public void CollectCoins()
        {
            MoneyBox.Instance.AddCurrency(Coins);
            Coins = 0;
            _rewardView.UpdateProgressBar(Coins);
        }

        public void Upgrade()
        {
            if (MoneyBox.Instance.SpendCurrency(200)) // Стоимость апгрейда шкалы
            {
                _accumulationRate *= 2; // Увеличиваем скорость накопления монет
                Debug.Log($"Шкала апгрейдена. Новая скорость накопления: {_accumulationRate}");
            }
        }
    }
}