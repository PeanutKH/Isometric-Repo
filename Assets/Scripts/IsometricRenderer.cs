using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricRenderer : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Same name as the animations in the Assets folder
    private static readonly string[] animations =
     { "Walk North", "Walk North West", "Walk West", "Walk South West",
        "Walk South", "Walk South East", "Walk East", "Walk North East" };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Find index based direction
    private int DirectionToIndex(Vector2 direction)
    {
        // Get the normalized direction
        Vector2 normDir = direction.normalized;

        // Get angle formed by direction
        float angle = Vector2.SignedAngle(Vector2.up, normDir);

        if (angle < 0) angle += 360; // Make the angle positive

        // Get index based on the angle
        return Mathf.FloorToInt(angle / 45.0f);

    }

    // Set the animation
    public void PlayAnimation(Vector2 direction)
    {
        if (direction.magnitude < 0.01f)
        {
            animator.Play("", -1, 0f);  // Stop and reset animation
        }
        else
        {
            int index = DirectionToIndex(direction);
            if (index < 0) Debug.Log(index);

            animator.Play(animations[index]);
        }
    }
}