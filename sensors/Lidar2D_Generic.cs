﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lidar2D_Generic : MonoBehaviour
{

    public float Range;
    public bool ActiveDebugRay;
    public float HorizontalResolution;
    public float Horizontal_FOV;

    private int layerMask;

    void Start()
    {
        layerMask = 1 << 8;
        layerMask = ~layerMask;

        Range = 200;
        ActiveDebugRay = false;
        HorizontalResolution = 10;
        Horizontal_FOV = 2 * 3.14f;

    }

    void FixedUpdate()
    {
        Raycast();

    }

    void Raycast()
    {
        RaycastHit hit;

        //config basis
        float radius = 1.0f;
        float angleHorizontal = 0;
        float step = Horizontal_FOV / HorizontalResolution;

        for (int i = 0; i < HorizontalResolution; ++i)
        {
            float direction_x = radius * Mathf.Cos(angleHorizontal);
            float direction_z = radius * Mathf.Sin(angleHorizontal);

            Vector3 direction = new Vector3(direction_x, 0, direction_z);

            if (Physics.Raycast(transform.position, direction, out hit, Range, layerMask))
            {
                if (ActiveDebugRay)
                {
                    Debug.DrawRay(transform.position, direction * hit.distance, Color.red);
                }
            }
            else
            {
                if (ActiveDebugRay)
                {
                    Debug.DrawRay(transform.position, direction * Range, Color.yellow);
                }
            }

            angleHorizontal += step;

        };

    }
}