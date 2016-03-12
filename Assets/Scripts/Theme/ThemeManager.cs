using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ThemeManager : MonoBehaviour {

    public Text[] m_Text;

    float ThemeNum;

    void Awake()
    {
        ThemeNum = PlayerPrefs.GetInt("ThemeNum");
        //PlayerPrefs로 최고기록 값을 가져와서 텍스트 영역에 뿌림
        for (int i = 0; i < m_Text.Length; ++i)
        {
            m_Text[i].text = PlayerPrefs.GetString("StartButton" + ThemeNum.ToString() + "_" + (i).ToString());
        }

        //StartButton1
        //StartButton0_0
        //StartButton0_1
        //....
        //StartButton0_9
        //StartButton1_0
        //StartButton1_1
    }

    public void ChangeScene(string strStart)
    {
        PlayerPrefs.SetString("StartPosition", strStart);
        SceneManager.LoadScene("map1");
    }

    public void Back()
    {
        SceneManager.LoadScene("ChooseMap");
    }

}
