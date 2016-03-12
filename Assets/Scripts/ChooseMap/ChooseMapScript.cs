using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChooseMapScript : MonoBehaviour {

    //public Text[] m_Text;

    
    //void Awake()
    //{
    //    //PlayerPrefs로 최고기록 값을 가져와서 텍스트 영역에 뿌림
    //    for(int i=0; i<m_Text.Length; ++i)
    //    {
    //        m_Text[i].text = PlayerPrefs.GetString("StartButton"+(i+1).ToString());
    //    }
    //}

    //public void ChangeScene(int StartNum)
    //{
    //    PlayerPrefs.SetInt("StartMap", StartNum);
    //    SceneManager.LoadScene("map1");
    //}

    //public void ChangeScene(string strStart)
    //{
    //    PlayerPrefs.SetString("StartPosition", strStart);
    //    SceneManager.LoadScene("map1");
    //}
    public void ChangeScene(int ThemeNum)
    {
        PlayerPrefs.SetInt("ThemeNum", ThemeNum);

        if(ThemeNum == 0)
            SceneManager.LoadScene("Forest");

        else if(ThemeNum == 1)
            SceneManager.LoadScene("Space");

        else if (ThemeNum == 2)
            SceneManager.LoadScene("Parkour");
    }
    



    public void Back()
    {
        SceneManager.LoadScene("main");
    }
}
