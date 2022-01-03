using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataReciiver : MonoBehaviour
{
    //JsonObject jsonObject = new JsonObject();

    public GameObject[] keyPoints = new GameObject[17];
    public GameObject nose1; 
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        // json = JsonUtility.ToJson(jsonObject);
        // TestJson(json);
    }

    public void TestJson(string testjson){
        JsonObject jsonObject = JsonUtility.FromJson<JsonObject>(testjson);
        Debug.Log(jsonObject.nose);
    }

    public void setNoseData(string data)
    {
        //var position = JsonUtility.FromJson<Vector3>(data);
        jsonObject1 pointsData = JsonUtility.FromJson<jsonObject1>(data);
        text.text = "nn" + pointsData.x +"sdf" + pointsData.y+ "sdf"+pointsData.z;
        //nose1.transform.position = new Vector3(pointsData.x/100, pointsData.y/100, pointsData.z/10);

        keyPoints[pointsData.i].transform.position = new Vector3(pointsData.x/100, pointsData.y/100, pointsData.z/10);
    }

    public class jsonObject1{
        public int length;
        public int i;
        public int x;
        public int y;
        public int z;
    }
    // public void setNoseData1(int data)
    // {
    //     text.text = data.ToString();
    //     //nose1.transform.position = new Vector3(data, 2, 2);
    // }
}