using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    // public int number;
    public Renderer[] clothRenderers;
    
    public CharacterDatabase characterDB;
    public Renderer mat1;
    public Renderer mat2;
    public Renderer mat3;
    public Renderer mat4;
    public Renderer mat5;
    public Renderer mat6;

    int SelectedOption;

    // Start is called before the first frame update
    
    void Start()
    {

    }

    
    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision col)
    {
        SelectedOption = DataReceiver.currentIndex;
        

        if (col.gameObject.tag == "MaterialObj1")
        {
            clothRenderers[SelectedOption].material = mat1.material;
        }
        if (col.gameObject.tag == "MaterialObj2")
        {
            clothRenderers[SelectedOption].material = mat2.material;
        }
        if (col.gameObject.tag == "MaterialObj3")
        {
            clothRenderers[SelectedOption].material = mat3.material;
        }
        if (col.gameObject.tag == "MaterialObj4")
        {
            clothRenderers[SelectedOption].material = mat4.material;
        }
        if (col.gameObject.tag == "MaterialObj5")
        {
            clothRenderers[SelectedOption].material = mat5.material;
        }
        if (col.gameObject.tag == "MaterialObj6")
        {
            clothRenderers[SelectedOption].material = mat6.material;
        }
        
    }

    public void changeMaterial1()
    {
        clothRenderers[SelectedOption].material = mat1.material;
    }
    public void changeMaterial2()
    {
        clothRenderers[SelectedOption].material = mat2.material;
    }
    public void changeMaterial3()
    {
        clothRenderers[SelectedOption].material = mat3.material;
    }
    public void changeMaterial4()
    {
        clothRenderers[SelectedOption].material = mat4.material;
    }
    public void changeMaterial5()
    {
        clothRenderers[SelectedOption].material = mat5.material;
    }
    public void changeMaterial6()
    {
        clothRenderers[SelectedOption].material = mat6.material;
    }
}
