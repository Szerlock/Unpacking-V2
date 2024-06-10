using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelveSlots : MonoBehaviour
{
private bool containsItem = false;
    private string currentItemType;
    private SpriteRenderer spriteRenderer;

    public Sprite[] icons;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(containsItem)
        {
            Debug.Log("item exist");
            if(other.CompareTag(currentItemType))
            {
            Destroy(other.gameObject);
            } 
            else
            {
            return;
            }
        }

        {
            currentItemType = other.gameObject.tag;
            Debug.Log("string actualized");

            Sprite itemIcon = FindIcon(currentItemType);
            SetIcon(itemIcon);

            containsItem = true;
            Destroy(other.gameObject);
        }
    }

    private Sprite FindIcon(string itemType)
    {
        foreach (Sprite icon in icons)
        {
            if(icon.name == currentItemType)
            {   
                return icon;
            }
        }
        return null;
    }

    private void SetIcon(Sprite icon)
    {
        if(spriteRenderer != null && icon != null)
        {
            spriteRenderer.sprite = icon;
        }
    }
}
