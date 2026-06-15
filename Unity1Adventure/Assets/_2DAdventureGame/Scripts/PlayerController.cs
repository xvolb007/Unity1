using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction action;
    private float Speed = 3f;
    Rigidbody2D rigidbody2D;
    Vector2 move;
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime je cas ktery uplyne mezi framy
        move = action.ReadValue<Vector2>();
        Debug.Log(move);
        
    }
    void FixedUpdate()
    {
        Vector2 position = (Vector2)transform.position + move * Speed * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }
}