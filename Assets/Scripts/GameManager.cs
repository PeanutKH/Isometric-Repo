using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] InventoryUIManager inventoryUIManager;

    private void OnEnable()
    {
        // Subscribe to the event
        PickUp.onPickUp += inventoryUIManager.UpdateUI;
    }

    private void OnDisable()
    {
        // Unsubscribe the event
        PickUp.onPickUp -= inventoryUIManager.UpdateUI;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
