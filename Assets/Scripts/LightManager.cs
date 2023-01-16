using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    private Transform[] _children;
    // Start is called before the first frame update
    void Start()
    {
        _children = transform.GetComponentsInChildren<Transform>();
    }

    public void ToggleLight()
    {
        foreach(Transform child in _children)
        {
            GameObject _child = child.gameObject;

            if (_child.activeSelf)
            {
                _child.SetActive(false);
            }
            else
            {
                _child.SetActive(true);
            }
        }
    }
}
