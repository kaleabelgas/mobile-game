using UnityEngine;

[CreateAssetMenu(fileName ="Weapon")]
public class Weapon : ScriptableObject
{
    public string Name;
    public int AttackValue;
    public float AttackRange;
    public Transform WeaponTransform = null;
    public LayerMask EnemyMask;

    public void AssignTransform(Transform WeaponTransform)
    {
        this.WeaponTransform = WeaponTransform;
    }
}
