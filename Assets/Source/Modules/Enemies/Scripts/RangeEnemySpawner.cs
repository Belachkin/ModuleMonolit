using UnityEngine;

namespace Enemies
{
    internal class RangeEnemySpawner : EnemySpawner
    {
        [SerializeField] private Enemy _enemy;
        [SerializeField] private Transform[] _spawnPoints;

        private int index = 0;
        protected override Enemy Spawn()
        {
            Transform spawnPoint = _spawnPoints[index];
            index++;

            return Instantiate(_enemy, spawnPoint.position, spawnPoint.rotation);

        }
    }
}
