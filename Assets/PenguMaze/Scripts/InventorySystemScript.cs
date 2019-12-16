using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystemScript : MonoBehaviour
{
    private int count;
    public Text countText;
    public Sprite defaultIcon;
    public Sprite inventoryIcon;
    public Image resourceIcon;

    void Start()
    {
        count = 0;
        resourceIcon.sprite = defaultIcon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            // When collided, this sets the collectable gameobject off
            other.gameObject.SetActive(false);
            count++;
            SetCountText();

            if (count == 0)
            {
                SetResourceIcon(defaultIcon);
            }
            else
                SetResourceIcon(inventoryIcon);
                
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString();
    }

    void SetResourceIcon(Sprite s)
    {
        resourceIcon.sprite = s;
    }
}
