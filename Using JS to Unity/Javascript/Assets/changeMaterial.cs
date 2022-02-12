using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    public int number;

    public Renderer[] cubeRenderer;
    public GameObject[] cube;
    public Material red;
    public Material green;
    public Material pink;
    public Material blue;
    public Material yellow;
    public Material black;
    public GameObject[] Colors;
    public GameObject[] buttons;
    public Vector3[] positions;
    
    
    

    // Start is called before the first frame update
    
    void Start()
    {
        cubeRenderer[number] = cube[number].GetComponent<Renderer>();
        if(number == 1)
        {
            Colors[1].SetActive(false);
            buttons[1].SetActive(false);
            buttons[0].transform.position = buttons[1].transform.position;


            Colors[0].transform.position = positions[0];
            Colors[2].transform.position = positions[1];
            Colors[3].transform.position = positions[2];
            Colors[4].transform.position = positions[3];
            Colors[5].transform.position = positions[4];
            Colors[6].transform.position = positions[5];


        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Green")
        {
            int num = 3;
            while(num == 0)
            {
                num = num - 1;
            }
            cubeRenderer[number].material = green;

            
            

            
            

        }
        if (col.gameObject.tag == "Blue")
        {
            cubeRenderer[number].material = blue;

        }
        if (col.gameObject.tag == "Yellow")
        {
            cubeRenderer[number].material = yellow;

        }
        if (col.gameObject.tag == "Red")
        {
            cubeRenderer[number].material = red;

        }
        if (col.gameObject.tag == "Black")
        {
            cubeRenderer[number].material = black;

        }
        if (col.gameObject.tag == "Pink")
        {
            cubeRenderer[number].material = pink;


        }



    }
}
