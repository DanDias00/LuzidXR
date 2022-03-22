// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class changeMaterial : MonoBehaviour
// {
//     // public int number;
//     public Renderer[] clothRenderers;
    
//     public CharacterDatabase characterDB;
//     public Renderer mat1;
//     public Renderer mat2;
//     public Renderer mat3;
//     public Renderer mat4;
//     public Renderer mat5;
//     public Renderer mat6;

//     int SelectedOption;

//     private float timeRemaining = 2f;
//     private bool collideObj1;
//     private bool collideObj2;
//     private bool collideObj3;
//     private bool collideObj4;
//     private bool collideObj5;
//     private bool collideObj6;

//     public Slider timerslideColor;

//     // Start is called before the first frame update
    
//     void Start()
//     {
//         timerslideColor.maxValue = timeRemaining;
//         timerslideColor.value = timeRemaining;
//     }

    
//     // Update is called once per frame
//     void Update()
//     {
//         timerslideColor.value = timeRemaining;
//         if(timeRemaining == 2f){
//             timerslideColor.gameObject.SetActive(false);
//         }else{
//             timerslideColor.gameObject.SetActive(true);
//         }
//         SelectedOption = DataReceiver.currentIndex;
//         //setting timer for 1st GameObject containing the color
//         if(collideObj1 == true){
//             timeRemaining -= Time.deltaTime;
//             if(timeRemaining <= 0){
//                 changeMaterial1();
//                 timeRemaining = 2f;
//             }
//         }//setting timer for 2nd GameObject containing the color
//         else if(collideObj2 == true){
//             timeRemaining -= Time.deltaTime;
//             if(timeRemaining <= 0){
//                 changeMaterial2();
//                 timeRemaining = 2f;
//             }
//         }//setting timer for 3rd GameObject containing the color
//         else if(collideObj3 == true){
//             timeRemaining -= Time.deltaTime;
//             if(timeRemaining <= 0){
//                 changeMaterial3();
//                 timeRemaining = 2f;
//             }
//         }//setting timer for 4th GameObject containing the color
//         else if(collideObj4 == true){
//             timeRemaining -= Time.deltaTime;
//             if(timeRemaining <= 0){
//                 changeMaterial4();
//                 timeRemaining = 2f;
//             }
//         }//setting timer for 5th GameObject containing the color
//         else if(collideObj5 == true){
//             timeRemaining -= Time.deltaTime;
//             if(timeRemaining <= 0){
//                 changeMaterial5();
//                 timeRemaining = 2f;
//             }
//         }//setting timer for 6th GameObject containing the color
//         else if(collideObj6 == true){
//             timeRemaining -= Time.deltaTime;
//             if(timeRemaining <= 0){
//                 changeMaterial6();
//                 timeRemaining = 2f;
//             }
//         }
//         else{
//             timeRemaining = 2f;
//         }
//     }

//     private void OnCollisionEnter(Collision col)
//     {
//         if (col.gameObject.tag == "MaterialObj1")
//         {
//             collideObj1 = true;
//         }
//         if (col.gameObject.tag == "MaterialObj2")
//         {
//             collideObj2 = true;
//         }
//         if (col.gameObject.tag == "MaterialObj3")
//         {
//             collideObj3 = true;
//         }
//         if (col.gameObject.tag == "MaterialObj4")
//         {
//             collideObj4 = true;
//         }
//         if (col.gameObject.tag == "MaterialObj5")
//         {
//             collideObj5 = true;
//         }
//         if (col.gameObject.tag == "MaterialObj6")
//         {
//             collideObj6 = true;
//         }
//     }
//     private void OnCollisionExit(Collision col)
//     {
//         collideObj1 = false;
//         collideObj2 = false;
//         collideObj3 = false;
//         collideObj4 = false;
//         collideObj5 = false;
//         collideObj6 = false;
//     }

//     public void changeMaterial1()
//     {
//         clothRenderers[SelectedOption].material = mat1.material;
//     }
//     public void changeMaterial2()
//     {
//         clothRenderers[SelectedOption].material = mat2.material;
//     }
//     public void changeMaterial3()
//     {
//         clothRenderers[SelectedOption].material = mat3.material;
//     }
//     public void changeMaterial4()
//     {
//         clothRenderers[SelectedOption].material = mat4.material;
//     }
//     public void changeMaterial5()
//     {
//         clothRenderers[SelectedOption].material = mat5.material;
//     }
//     public void changeMaterial6()
//     {
//         clothRenderers[SelectedOption].material = mat6.material;
//     }
// }


