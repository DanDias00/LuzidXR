using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject colors;
    public GameObject colorButtons;
    public GameObject sizes;
    public GameObject clothes;
    public GameObject changeClothes;
    // Start is called before the first frame update
    void Start()
    {
        clothes.SetActive(true);
        changeClothes.SetActive(true);
        colors.SetActive(false);
        colorButtons.SetActive(false);
        sizes.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "colors")
        {
            colors.SetActive(true);
            sizes.SetActive(false);
            colorButtons.SetActive(true);
            changeClothes.SetActive(false);

        }
        
        if (col.gameObject.tag == "sizes")
        {
            sizes.SetActive(true);
            colors.SetActive(false);
            changeClothes.SetActive(false);
            colorButtons.SetActive(false);
        }
        if (col.gameObject.tag == "clothes")
        {
            
            
            colorButtons.SetActive(false);
            colors.SetActive(false);
            sizes.SetActive(false);
            changeClothes.SetActive(true);
        }
    }
}
