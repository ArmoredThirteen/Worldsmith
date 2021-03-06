﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMap : MonoBehaviour
{
    // Prefab script for SubMaps:  Data types that link with the background map holders and enable switching between background maps

    public GameObject highlightObject;

    public Sprite fullMap1;
    public Sprite fullMap2;
    public Sprite fullMap3;
     

    private void Start()
    {
        //TODO: Scale highlight and box collider automatically here
        //float xSize = this.GetComponent<SpriteRenderer>().bounds.size.x;
        //float ySize = this.GetComponent<SpriteRenderer>().bounds.size.y;
        //Debug.Log("x" + this.GetComponent<SpriteRenderer>().bounds.size.x);
        //RectTransform rt = highlightObject.GetComponent(typeof(RectTransform)) as RectTransform;
        //rt.sizeDelta = new Vector2(xSize, ySize); 
    }


    private void OnMouseOver()
    {
        highlightObject.SetActive(true);
        MapController.Instance.HoverClickable(transform.name);
    }
    private void OnMouseExit()
    {
        highlightObject.SetActive(false);
        MapController.Instance.ExitHoverClickable();
    }
    private void OnMouseDown()
    {
        highlightObject.SetActive(false);
        MapController.Instance.ClickSubMap(this);
    }
}
