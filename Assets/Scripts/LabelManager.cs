using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LabelManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _label;
    // Start is called before the first frame update
    void Start()
    {
        _label.text = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
