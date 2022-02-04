using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataReceiver : MonoBehaviour
{
    public GameObject[] keyPoints = new GameObject[12];
    public GameObject WholeBody; 
    public Text textright;
    public Text textleft;


    void Start()
    {
        
    }

    void update()
    {
        
    } 

    public void keypointData(string data)
    {
        jsonObject pointsData = JsonUtility.FromJson<jsonObject>(data);

        //nose
        keyPoints[0].transform.position = new Vector3(-1*pointsData.data0.x, -1*pointsData.data0.y, pointsData.data0.z);
        //textleft.text = "right - x " + pointsData.data1.x +" y " + pointsData.data1.y+ " z "+pointsData.data1.z;
        //textright.text = "left - x " + pointsData.data8.x +" y " + pointsData.data8.y+ " z "+pointsData.data8.z;

        //left shoulder
        keyPoints[1].transform.position = new Vector3(-1*pointsData.data11.x, -1*pointsData.data11.y, pointsData.data11.z);
        //right shoulder
        keyPoints[2].transform.position = new Vector3(-1*pointsData.data12.x, -1*pointsData.data12.y, pointsData.data12.z);
        //left elbow
        keyPoints[3].transform.position = new Vector3(-1*pointsData.data13.x, -1*pointsData.data13.y, pointsData.data13.z);
        //right elbow
        keyPoints[4].transform.position = new Vector3(-1*pointsData.data14.x, -1*pointsData.data14.y, pointsData.data14.z);
        //left wrist
        keyPoints[5].transform.position = new Vector3(-1*pointsData.data15.x, -1*pointsData.data15.y, pointsData.data15.z);
        //right wrist
        keyPoints[6].transform.position = new Vector3(-1*pointsData.data16.x, -1*pointsData.data16.y, pointsData.data16.z);
        
        //left hip
        keyPoints[7].transform.position = new Vector3(-1*pointsData.data23.x, -1*pointsData.data23.y, pointsData.data23.z);
        //right hip
        keyPoints[8].transform.position = new Vector3(-1*pointsData.data24.x, -1*pointsData.data24.y, pointsData.data24.z);
        //left knee
        keyPoints[9].transform.position = new Vector3(-1*pointsData.data25.x, -1*pointsData.data25.y, pointsData.data25.z);
        //right knee
        keyPoints[10].transform.position = new Vector3(-1*pointsData.data26.x, -1*pointsData.data26.y, pointsData.data26.z);
        //left ankle
        keyPoints[11].transform.position = new Vector3(-1*pointsData.data27.x, -1*pointsData.data27.y, pointsData.data27.z);
        //right ankle
        keyPoints[12].transform.position = new Vector3(-1*pointsData.data28.x, -1*pointsData.data28.y, pointsData.data28.z);
    }

    public class jsonObject{
        public Vector3 data0;
        
        public Vector3 data11;
        public Vector3 data12;
        public Vector3 data13;
        public Vector3 data14;
        public Vector3 data15;
        public Vector3 data16;

        public Vector3 data23;
        public Vector3 data24;
        public Vector3 data25;
        public Vector3 data26;
        public Vector3 data27;
        public Vector3 data28;
    }
}