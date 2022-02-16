using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sizeChange : MonoBehaviour
{


    private float timeRemaining = 3f;
    private bool collideObjSmall;
    private bool collideObjMedium;
    private bool collideObjLarge;


    void Start()
    {
    }

    void Update()
    {
        if (collideObjSmall == true)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                btn_change_One();
                timeRemaining = 3f;
            }
        }//setting timer for 2nd GameObject containing the color
        else if (collideObjMedium == true)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                btn_change_Two();
                timeRemaining = 3f;
            }
        }//setting timer for 3rd GameObject containing the color
        else if (collideObjLarge == true)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                btn_change_Three();
                timeRemaining = 3f;
            }
        }
        else
        {
            timeRemaining = 3f;
        }
    }

    private void OnCollisionEnter(Collision collision)

    {


        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "CubeS")
        {


            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("SIZE CHANGED");

            collideObjSmall = true;


        }

        if (collision.gameObject.name == "CubeM")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("SIZE CHANGED");
            collideObjMedium = true;


        }

        if (collision.gameObject.name == "CubeL")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("SIZE CHANGED");
            collideObjLarge = true;


        }


    }

    private void OnCollisionExit(Collision col)
    {
        collideObjSmall = false;
        collideObjMedium = false;
        collideObjLarge = false;

    }



    public void btn_change_One()
    {
        this.transform.localScale = new Vector3(2f, 2f, 2f);
    }

    public void btn_change_Two()
    {
        this.transform.localScale = new Vector3(3f, 3f, 3f);
    }
    public void btn_change_Three()
    {
        this.transform.localScale = new Vector3(4f, 4f, 4f);
    }
}