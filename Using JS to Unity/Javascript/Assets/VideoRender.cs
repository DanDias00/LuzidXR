using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoRender : MonoBehaviour
{
    public RenderTexture videoTexture;

    public GameObject videoScreen;

    // The height of the current video source
    private int videoHeight;

    // The width of the current video source
    private int videoWidth;

    // Live video input from a webcam
    private WebCamTexture webcamTexture;
    public Vector2Int webcamDims = new Vector2Int(1280, 720);
    public int webcamFPS = 60;

    void Start()
    {
        startWebCam ();
    }

    void update()
    {
        //Graphics.Blit(webcamTexture, videoTexture);
    }
    void startWebCam() {
        WebCamDevice device = WebCamTexture.devices[0];

        webcamTexture = new WebCamTexture (device.name);
        videoScreen.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", webcamTexture);
        //videoTexture.material.mainTexture = webcamTexture;
        webcamTexture.Play ();
    }
}
