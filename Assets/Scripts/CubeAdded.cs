using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAdded : MonoBehaviour
{
    public GameObject _sceneCube;
    int _yPosition;
    void Start()
    {
        _sceneCube = GameObject.Find("SceneCube");
    }

    void Update()
    {
        _sceneCube.transform.position = new Vector3(transform.position.x, _yPosition + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -_yPosition, 0);
    }

    public void PositionExtaction()
    {
        _yPosition--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SceneCubeObject" && other.gameObject.GetComponent<CollectableCube>().GetCubeAdded() == false)
        {
            _yPosition += 1;
            other.gameObject.GetComponent<CollectableCube>().Added();
            other.gameObject.GetComponent<CollectableCube>().IndexAdd(_yPosition);
            other.gameObject.transform.parent = _sceneCube.transform;
        }
    }
}
