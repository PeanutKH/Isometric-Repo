using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
{
    private Vector2 attackPoint;
    float range = 0.3f;

    public Vector2 AttackPoint
    {
        get { return attackPoint; }
        set { attackPoint = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (attackPoint == null)
        {
            attackPoint = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse position in the world space
        Vector2 mousePositionWorld =
                Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Find direction from object to mouse
        Vector2 objectToMouse = mousePositionWorld -
                new Vector2(transform.position.x, transform.position.y);

        // Update attack point according to 
        // direction of object to mouse by 0.5 unit distance
        attackPoint = new Vector2(transform.position.x, transform.position.y) +
                      objectToMouse.normalized * 0.5f;

        // Perform collision check only when left mouse is down
        if (Input.GetMouseButtonDown(0))
        {

            Collider2D collider = CheckHit();
            if (collider != null) // it hits something
            {
                Debug.Log(collider.gameObject.name);
                // Implement some effects to inflict damage
            }

        }
    }

    public Collider2D CheckHit()
    {
        // Second argument is the distance
        return Physics2D.OverlapCircle(attackPoint, range);
    }

    private void OnDrawGizmos()
    {
        // Set the gizmos color
        Gizmos.color = Color.red;

        // Draw a gizmos at the attackPoint within given range
        Gizmos.DrawWireSphere(AttackPoint, range);
    }
}