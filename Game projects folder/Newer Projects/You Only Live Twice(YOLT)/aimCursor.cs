﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimCursor : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTextureArray;
    public float crosshairOffsetX;
    public float crosshairOffsetY;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
       // Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // transform.position = mouseCursorPos;
    }
}
