// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class sizeChange : MonoBehaviour
// {
//     public GameObject clothes;

//     private float timeRemaining = 2f;
//     private bool collideObjSmall;
//     private bool collideObjMedium;
//     private bool collideObjLarge;
//     public Slider timersliderSize;

//     void Start()
//     {
//         timersliderSize.maxValue = timeRemaining;
//         timersliderSize.value = timeRemaining;
//     }

//     void Update()
//     {
//         timersliderSize.value = timeRemaining;
//         if(timeRemaining == 2f){
//             timersliderSize.gameObject.SetActive(false);
//         }else{
//             timersliderSize.gameObject.SetActive(true);
//         }
//         if (collideObjSmall == true)
//         {
//             timeRemaining -= Time.deltaTime;
//             if (timeRemaining <= 0)
//             {
//                 btn_change_One();
//                 timeRemaining = 2f;
//             }
//         }//setting timer for 2nd GameObject containing the color
//         else if (collideObjMedium == true)
//         {
//             timeRemaining -= Time.deltaTime;
//             if (timeRemaining <= 0)
//             {
//                 btn_change_Two();
//                 timeRemaining = 2f;
//             }
//         }//setting timer for 3rd GameObject containing the color
//         else if (collideObjLarge == true)
//         {
//             timeRemaining -= Time.deltaTime;
//             if (timeRemaining <= 0)
//             {
//                 btn_change_Three();
//                 timeRemaining = 2f;
//             }
//         }
//         else
//         {
//             timeRemaining = 2f;
//         }
//     }

//     private void OnCollisionEnter(Collision collision)

//     {
//         //Check for a match with the specified name on any GameObject that collides with your GameObject
//         if (collision.gameObject.name == "CubeS")
//         {
//             //If the GameObject's name matches the one you suggest, output this message in the console
//             collideObjSmall = true;
//         }

//         if (collision.gameObject.name == "CubeM")
//         {
//             //If the GameObject's name matches the one you suggest, output this message in the console
//             collideObjMedium = true;
//         }

//         if (collision.gameObject.name == "CubeL")
//         {
//             //If the GameObject's name matches the one you suggest, output this message in the console
//             collideObjLarge = true;
//         }
//     }

//     private void OnCollisionExit(Collision col)
//     {
//         collideObjSmall = false;
//         collideObjMedium = false;
//         collideObjLarge = false;
//     }

//     public void btn_change_One()
//     {
//         clothes.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
//     }
//     public void btn_change_Two()
//     {
//         clothes.transform.localScale = new Vector3(1f, 1f, 1f);
//     }
//     public void btn_change_Three()
//     {
//         clothes.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
//     }
// }