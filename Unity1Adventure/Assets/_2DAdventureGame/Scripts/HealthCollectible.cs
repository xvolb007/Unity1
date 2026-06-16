using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController controller = collision.GetComponent<PlayerController>();
        if(controller != null)
        {
            controller.ChangeHealth(2);
            Destroy(gameObject);
        }
    }
}
