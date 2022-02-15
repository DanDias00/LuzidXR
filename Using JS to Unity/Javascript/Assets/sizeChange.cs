using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sizeChange : MonoBehaviour
{
    public GameObject[] clothes;
    int selectedOption;
    void update()
    {
        selectedOption = DataReceiver.currentIndex;
    }

    [SerializeField] float delay = 3f;

     void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "CubeS")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("SIZE CHANGED");
            StartCoroutine(DelayDeactivate(delay));
            clothes[selectedOption].transform.localScale = new Vector3(2f, 2f, 2f);
           
        }

        if (collision.gameObject.name == "CubeM")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("SIZE CHANGED");
            clothes[selectedOption].transform.localScale = new Vector3(3f, 3f, 3f);
            
        }

        if (collision.gameObject.name == "CubeL")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("SIZE CHANGED");
            clothes[selectedOption].transform.localScale = new Vector3(4f, 4f, 4f);
      
        }
    }

    IEnumerator DelayDeactivate(float _delay)
    {
        yield return new WaitForSeconds(_delay);
        //this.gameObject.SetActive(true);
    }



    public void btn_change_One()
    {
        clothes[selectedOption].transform.localScale = new Vector3(1f, 1f, 1f);
    }

    public void btn_change_Two()
    {
        clothes[selectedOption].transform.localScale = new Vector3(2f, 2f, 2f);
    }
    public void btn_change_Three()
    {
        clothes[selectedOption].transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
    }
}