using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction action;
    private float Speed = 3f;
    public int maxHealth = 10;
    private int currentHealth;
    Rigidbody2D rigidbody2D;
    Vector2 move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        action.Enable();
        currentHealth = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        // Time.deltaTime je cas ktery uplyne mezi framy
        move = action.ReadValue<Vector2>();
        Debug.Log(move);
        
    }
    private void FixedUpdate()
    {
        Vector2 position = (Vector2)transform.position + move * Speed * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }
    private void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log($"{currentHealth} / {maxHealth}");
    }
}