using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameManger : MonoBehaviour
{
    // Start is called before the first frame update
    public Text inputName;
    public TMP_Text Name;
    void Start()
    {
        Name.text = inputName.text;
    }

    // Update is called once per frame
    void Update()
    {
        Name.text = inputName.text;

    }

}
