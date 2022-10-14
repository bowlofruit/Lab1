using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    public void Kill()
    {
        Debug.Log("Oh shit, i'm sorry");
    }

    public void Damage(float damageTaken)
    {
        Debug.Log("Oh, that hurt");
    }
}
