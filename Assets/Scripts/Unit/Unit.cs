using System;
using UnityEngine;

namespace SbSTanks
{
    public abstract class Unit : MonoBehaviour, IDamagebleUnit, IUnit
    {
        public Action<int> TakeDamage { get; set; }
        public Action<GameObject, IDamagebleUnit> ShellHit { get; set; }

        [SerializeField] protected UnitParameters _parameters;
        [SerializeField] protected Transform _shotStartPoint;

        protected ShellController _shellController;
        protected StepController _stepController;

        protected const float SHOT_FORCE = 180f;

        public IParameters Parameters { get => _parameters; }
        public Transform GetShotPoint { get => _shotStartPoint; }
        public Transform Transform { get => gameObject.transform; }

        public void Init(UnitInitializationData data, ShellController shellController, StepController stepController)
        {
            _parameters = new UnitParameters(this, data.hp, data.damage);
            _shellController = shellController;
            _stepController = stepController;
        }

        protected abstract void OnCollisionEnter(Collision collision);

        public void TakingDamage(int damage)
        {
            Debug.Log("Auch!");
            TakeDamage?.Invoke(damage);
        }
    }
}
