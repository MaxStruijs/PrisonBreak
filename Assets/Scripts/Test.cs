using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        //TestCreateItem();
        TestInventory();
    }

    public void TestCreateItem()
    {
        Item i = new AccesItem("Key", 10, 1);
        DebugItem(i);

        Item j = new BonusItem("potato of the gods", 2, 100);
        DebugItem(j);
    }

    private void TestInventory()
    {
        Item i = new AccesItem("Key of Doom", 10, 1);
        Item j = new BonusItem("potato of the gods", 50, 50);
        Item k = new BonusItem("Globe of eternal sunshine", 50, 100);

        if (inventory.AddItem(i))
        {
            Debug.Log("Succes" + i.GetName());
        }
        else
        {
            Debug.Log("Failed" + i.GetName());
        }
        if (inventory.AddItem(j))
        {
            Debug.Log("Succes" + j.GetName());
        }
        else
        {
            Debug.Log("Failed" + j.GetName());
        }
        if (inventory.AddItem(k))
        {
            Debug.Log("Succes" + k.GetName());
        }
        else
        {
            Debug.Log("Failed" + k.GetName());
        }

        inventory.DebugInventory();

        if (inventory.CanOpenDoor(1))
        {
            Debug.Log("Door can be opend");
        }
        else
        {
            Debug.Log("Door cannot be opend");
        }
        if (inventory.CanOpenDoor(2))
        {
            Debug.Log("Door can be opend");
        }
        else
        {
            Debug.Log("Door cannot be opend");
        }
    }

    public void DebugItem(Item i)
    {
        string itemInfo = "The Item: " + (i.GetName()) + " weighs " + i.GetWeight() + " KG";
        string extraInfo = "";
        if (i is AccesItem)
        {
            AccesItem ai = (AccesItem)i;
            extraInfo = " and opens door: " + ai.GetDoorId();
        }
        else if (i is BonusItem)
        {
            BonusItem bi = (BonusItem)i;
            extraInfo = " and gives you: " + bi.GetPoints() + " points";
        }
        Debug.Log( itemInfo + extraInfo);
    }
}