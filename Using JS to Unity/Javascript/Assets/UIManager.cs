using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static bool handAbility;
    public GameObject colorObj;
    public GameObject colorPanel;
    public GameObject sizePanel;
    public GameObject sizeObj;
    public GameObject mainPanel;
    public GameObject mainObj;
    public GameObject clothsBtn;
    public GameObject sizeBtn;
    public GameObject colorBtn;

    // Start is called before the first frame update
    void Start()
    {
        handAbility = true;
        sizeObj.SetActive(false);
        mainPanel.SetActive(true);
        colorObj.SetActive(false);
        colorPanel.SetActive(false);
        sizePanel.SetActive(false);
        clothsBtn.SetActive(false);
        colorBtn.SetActive(true);
        sizeBtn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "ColorSphere")
        {
            changeColor();
        }
        if (col.gameObject.name == "SizeSphere")
        {
            changeSize();
        }
        if (col.gameObject.name == "BackSphere")
        {
            cloth();
        }
    }

    public void changeColor()
    {
        handAbility = false;
        colorObj.SetActive(true);
        sizePanel.SetActive(false);
        sizeObj.SetActive(false);
        colorPanel.SetActive(true);
        mainPanel.SetActive(false);
        mainObj.SetActive(false);
        clothsBtn.SetActive(true);
        colorBtn.SetActive(false);
        sizeBtn.SetActive(false);
    }
    public void changeSize()
    {
        handAbility = false;
        sizePanel.SetActive(true);
        sizeObj.SetActive(true);
        colorObj.SetActive(false);
        mainPanel.SetActive(false);
        mainObj.SetActive(false);
        colorPanel.SetActive(false);
        clothsBtn.SetActive(true);
        colorBtn.SetActive(false);
        sizeBtn.SetActive(false);
    }
    public void cloth()
    {
        handAbility = true;
        sizeObj.SetActive(false);
        mainPanel.SetActive(true);
        mainObj.SetActive(true);
        colorObj.SetActive(false);
        colorPanel.SetActive(false);
        sizePanel.SetActive(false);
        clothsBtn.SetActive(false);
        colorBtn.SetActive(true);
        sizeBtn.SetActive(true);
    }
}
