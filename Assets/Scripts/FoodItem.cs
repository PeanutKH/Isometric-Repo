using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public void DoEffect(InventoryData inventoryData)
    {
        inventoryData.CountFoodItem++;
        Destroy(this.gameObject);
    }
}