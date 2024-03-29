﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform targetTransform;
    readonly float speed = 7.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * speed;

        float distanceToTarget = displacementFromTarget.magnitude;
        
        if (distanceToTarget > 3.0f) {
            transform.Translate(velocity * Time.deltaTime, Space.World);
        }
        else if (distanceToTarget < 2.0f) {
            transform.Translate(-velocity * Time.deltaTime, Space.World);
        }
    }
}
