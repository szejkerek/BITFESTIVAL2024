using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100;

    void DecreaseHealth(float amount)
    {
        health -= amount;
        if (health < 0) Kill();
    }

    void Kill()
    {
        Destroy(gameObject);
    }

}
