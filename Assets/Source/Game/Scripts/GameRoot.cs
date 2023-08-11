using UnityEngine;
using Movement;
using Shooting;
public class GameRoot : MonoBehaviour
{
    [SerializeField] private MovementInput _movementInput;
    [SerializeField] private WeaponInput _weaponInput;
    private void Start()
    {
        _movementInput.Activate();
        _weaponInput.Activate();
    }
}
