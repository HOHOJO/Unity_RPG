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
    public Image ch_1;
    public Image ch_2;
    public Image select;
    public Sprite Main_1;
    public Sprite Main_2;
    public Sprite Main;

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
            select = ch_1;
            Main = Main_1;
        }
        else
        {
            select = ch_2;
            Main = Main_2;
        }

    }
}
