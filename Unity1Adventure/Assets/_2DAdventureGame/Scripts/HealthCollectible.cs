using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public int healAmount = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController controller = collision.GetComponent<PlayerController>();
        if(controller != null)
        {
            controller.ChangeHealth(healAmount);
            Destroy(gameObject);
        }
    }
}
