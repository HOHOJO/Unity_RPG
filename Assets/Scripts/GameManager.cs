using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text NameText;
    public InputField inputName;
    public Button btn;
    public GameObject ch_1;
    public GameObject ch_2;
    public GameObject select;
    public GameObject Main_1;
    public GameObject Main_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NameAdd()
    {
        NameText.text = inputName.text;
    }

    public void selectImage(int i)
    {
        if(i == 1)
        {
            select.SetActive(false);
            ch_1.SetActive(true);
            ch_2.SetActive(false);
            Main_1.SetActive(true);
            Main_2.SetActive(false);
        }
        else
        {
            select.SetActive(false);
            ch_1.SetActive(false);
            ch_2.SetActive(true);
            Main_2.SetActive(true);
            Main_1.SetActive(false);
        }

    }
}
