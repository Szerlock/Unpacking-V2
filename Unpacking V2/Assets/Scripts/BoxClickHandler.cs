using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClickHandler : MonoBehaviour
{
    [SerializeField] 
    private Sprite newIcon;
    [SerializeField]
    private GameObject draggableObjectPrefab;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        ChangeIcon();
        SpawnDragableObject();
    }

    private void SpawnDragableObject()
    {
        if (draggableObjectPrefab != null)
        {
            Instantiate(draggableObjectPrefab, transform.position, Quaternion.identity);
        }
    }

    void ChangeIcon()
    {
        if (spriteRenderer != null && newIcon != null)
        {
            spriteRenderer.sprite = newIcon;
        }
    }

}
