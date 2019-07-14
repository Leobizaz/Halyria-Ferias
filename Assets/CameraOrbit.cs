using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform cameraOrbit;
    public Transform target;

    void Start()
    {
        cameraOrbit.position = target.position;
        cameraOrbit.rotation = Quaternion.Euler(0, 90, 90);
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);

        transform.LookAt(target.position);
    }
}
