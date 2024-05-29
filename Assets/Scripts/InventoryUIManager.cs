using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIManager : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text textFoodItemCount;
    [SerializeField] InventoryData inventoryData;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateUI()
    {
        if (inventoryData != null)
        {
            textFoodItemCount.text = "x " + inventoryData.CountFoodItem;
        }
    }

    private void OnEnable()
    {
        // onPickUp is public and static so we can easily access
        PickUp.onPickUp += UpdateUI;
    }
}
