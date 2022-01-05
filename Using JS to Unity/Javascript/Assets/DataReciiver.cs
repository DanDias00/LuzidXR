using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataReciiver : MonoBehaviour
{
    //JsonObject jsonObject = new JsonObject();

    public GameObject[] keyPoints = new GameObject[17];
    public GameObject WholeBody; 
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
        keyPoints[0].transform.position = new Vector3(pointsData.x/100, pointsData.y/100, pointsData.z/10);
    }
    public void setNoseData1(string data)
    {
        jsonObject2 pointsData1 = JsonUtility.FromJson<jsonObject2>(data);
        keyPoints[1].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }
    public void setNoseData2(string data)
    {
        jsonObject3 pointsData1 = JsonUtility.FromJson<jsonObject3>(data);
        keyPoints[2].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }

    public void setNoseData3(string data)
    {
        jsonObject4 pointsData1 = JsonUtility.FromJson<jsonObject4>(data);
        keyPoints[3].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }
    public void setNoseData4(string data)
    {
        jsonObject5 pointsData1 = JsonUtility.FromJson<jsonObject5>(data);
        keyPoints[4].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }
    public void setNoseData5(string data)
    {
        jsonObject6 pointsData1 = JsonUtility.FromJson<jsonObject6>(data);
        keyPoints[5].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }

    public void setNoseData6(string data)
    {
        jsonObject7 pointsData1 = JsonUtility.FromJson<jsonObject7>(data);
        keyPoints[6].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }
    public void setNoseData7(string data)
    {
        jsonObject8 pointsData1 = JsonUtility.FromJson<jsonObject8>(data);
        keyPoints[7].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }
    public void setNoseData8(string data)
    {
        jsonObject9 pointsData1 = JsonUtility.FromJson<jsonObject9>(data);
        keyPoints[8].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }

    public void setNoseData9(string data)
    {
        jsonObject10 pointsData1 = JsonUtility.FromJson<jsonObject10>(data);
        keyPoints[9].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }
    public void setNoseData10(string data)
    {
        jsonObject11 pointsData1 = JsonUtility.FromJson<jsonObject11>(data);
        keyPoints[10].transform.position = new Vector3(pointsData1.x/100, pointsData1.y/100, pointsData1.z/10);
    }


    public class jsonObject1{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject2{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject3{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject4{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject5{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject6{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject7{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject8{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject9{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject10{
        public int x;
        public int y;
        public int z;
    }
    public class jsonObject11{
        public int x;
        public int y;
        public int z;
    }
}