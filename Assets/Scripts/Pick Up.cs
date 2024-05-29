using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PickUp : MonoBehaviour
{
    [SerializeField] GameObject pickUpEffect;
    [SerializeField] InventoryData inventoryData;

    public interface Item
    {
        public void DoEffect(InventoryData inventoryData);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Ensure the name to compare in the hierarchy is the same
        Item item = collision.GetComponent<Item>();
        if (item != null)
        {
            item.DoEffect(inventoryData);
            onPickUp?.Invoke();
        }
    }

    // Define the event onPickUp
    // public and static so that it can be easily access from other scripts
    public static event System.Action onPickUp;
}
