using UnityEngine;
using System.Collections;

public class Set : MonoBehaviour
{
    // Use this for initialization
    public Camera CP;
    void Start()
    {
        UIRoot uiroot = gameObject.GetComponent<UIRoot>();
        uiroot.automatic = true;

        uiroot.manualHeight = 480;
        uiroot.minimumHeight = 480;
        uiroot.maximumHeight = 1920;
    }
    void Update()
    {
        float perx = 1280.0f / Screen.width;
        float pery = 720.0f / Screen.height;
        float v = (perx > pery) ? perx : pery;
        CP.GetComponent<Camera>().orthographicSize = v / 1.5f;
    }
}
