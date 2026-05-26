using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + Speed;
        position.y = position.y + Speed;
        transform.position = position;
    }
}