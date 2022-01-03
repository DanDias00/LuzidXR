using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectArray : MonoBehaviour
{
    JsonObject jsObjc = new JsonObject();

    public GameObject nose1;
    public GameObject leftEye1;
    public GameObject rightEye1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nose1.transform.position = new Vector3(2, 5, 0);
        leftEye1.transform.position = new Vector3(jsObjc.leftEye.x, jsObjc.leftEye.y, 0);
        rightEye1.transform.position = new Vector3(jsObjc.rightEye.x, jsObjc.rightEye.y, 0);
    }
}
