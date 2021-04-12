using UnityEngine;

[CreateAssetMenu(fileName ="Entity")]
public class Entity : ScriptableObject
{
    public string Name;
    public int Health;
    public int MoveSpeed;
    public int StrengthValue;
}
