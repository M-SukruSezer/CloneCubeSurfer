using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _sceneCube;
    public Vector3 _position;

    
    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, _sceneCube.transform.position + _position, Time.deltaTime);
    }
}
