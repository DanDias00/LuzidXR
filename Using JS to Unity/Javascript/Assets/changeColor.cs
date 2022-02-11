using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
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



    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer[number] = cube[number].GetComponent<Renderer>();



    }

    // Update is called once per frame
    void Update()
    {

    }



    public void changeMaterialRed()
    {

        cubeRenderer[number].material = red;

    }
    public void changeMaterialGreen()
    {

        cubeRenderer[number].material = green;

    }
    public void changeMaterialBlue()
    {

        cubeRenderer[number].material = blue;

    }
    public void changeMaterialYellow()
    {

        cubeRenderer[number].material = yellow;

    }
    public void changeMaterialPink()
    {

        cubeRenderer[number].material = pink;

    }
    public void changeMaterialBlack()
    {

        cubeRenderer[number].material = black;

    }
}
