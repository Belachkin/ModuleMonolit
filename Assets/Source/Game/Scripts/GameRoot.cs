using UnityEngine;
using Movement;
using Shooting;
using Enemies;

public class GameRoot : MonoBehaviour
{
    [SerializeField] private MovementInput _movementInput;
    [SerializeField] private WeaponInput _weaponInput;
    [SerializeField] private EnemySpawner _enemySpawner;

    private void Start()
    {
        _movementInput.Activate();
        _weaponInput.Activate();
        _enemySpawner.StartSpawn();
    }
}
