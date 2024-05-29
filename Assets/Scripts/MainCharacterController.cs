using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    [SerializeField]
    private MovementController moveController;

    [SerializeField]
    private IsometricRenderer isoRenderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);

        moveController.MovePosition(direction);
        isoRenderer.PlayAnimation(direction);
    }
}