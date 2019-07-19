using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform cameraOrbit;
    public Transform target;
    private TransitionCamera transition;

    void Start()
    {
        cameraOrbit.position = target.position;
        cameraOrbit.rotation = Quaternion.Euler(0, 90, 90);
        transition = gameObject.GetComponent<TransitionCamera>();
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);

        transform.LookAt(target.position);

        if(Selecionar.Ju || Selecionar.Bylogah || Selecionar.Furry)
        {
            transition.enabled = true;
        }
    }
}
