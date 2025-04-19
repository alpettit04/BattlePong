using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public GameObject Paddle { get; set; }

    public float speed = 2;

    private Vector3 movementInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //var logic = FindFirstObjectByType<GameLogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Paddle.transform.position += movementInput;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        var b = context.ReadValue<float>();
        movementInput = Vector3.up * b * speed * Time.deltaTime;
    }
}
