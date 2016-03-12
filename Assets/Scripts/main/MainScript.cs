using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainScript : MonoBehaviour {


    //public void ChangeScene(int StartNum)
    //{
    //    if(StartNum == 0)
    //        SceneManager.LoadScene("ChooseMap");
    //    else if(StartNum == 1)
    //    {

    //    }
    //    else
    //    {
            
    //    }


    //}

    public void StartButton()
    {
        SceneManager.LoadScene("ChooseMap");
    }

    public void Ranking()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    //폰에서 뒤로가기 누르면 종료
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }
}
