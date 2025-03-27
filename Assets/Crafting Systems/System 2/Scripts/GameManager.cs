using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

    }

    private void Start()
    {

        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
       
}
