using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    public float speed = 5;
    public CharacterController controller;
    public SpriteRenderer spriteRenderer;
    private Vector2 movementInput = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var move = new Vector3(movementInput.x, movementInput.y, 0);
        controller.Move(move * Time.deltaTime * speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnChangeColor(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        
        //spriteRenderer.color = new Color(Random.Range(0,255), Random.Range(0, 255), Random.Range(0, 255));
    }
}
