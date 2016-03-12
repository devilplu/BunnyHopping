using UnityEngine;
using System.Collections;

public class DisplayMgr : MonoBehaviour {

    // Use this for initialization
    void Awake()
    {
        //mobile
        Screen.SetResolution(1280, 720, true);
        Screen.orientation = ScreenOrientation.Landscape;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    
}
