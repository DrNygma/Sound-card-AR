using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform Target;
    float rotX;
    public float speedRotateX = 1;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            rotX = (Input.touches[0].deltaPosition.x * speedRotateX * Mathf.Deg2Rad);
        }
        Target.RotateAround(Target.transform.position, Target.up, - rotX);
    }
}
