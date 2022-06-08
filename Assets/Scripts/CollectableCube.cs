using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool _cubeAdded;
    int _cubeIndex;
    public CubeAdded _sceneAdded;

    private void Start()
    {
        _cubeAdded = false;
    }

    private void Update()
    {
        if (_cubeAdded == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -_cubeIndex, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            _sceneAdded.PositionExtaction();
            this.transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetCubeAdded()
    {
        return _cubeAdded;
    }

    public void Added()
    {
        _cubeAdded = true;
    }

    public void IndexAdd(int index)
    {
        this._cubeIndex = index;
    }
}
