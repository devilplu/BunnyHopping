using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseButtonScript : MonoBehaviour {
    public GameObject m_PauseButton;
    public GameObject m_UI;
    public GameObject m_NGUI;

    public Button m_Button;
   
	void Awake()
    {
        
    }
    public void Pause()
    {
        //일시정지
        Time.timeScale = 0;

        //퍼즈 버튼 비활성화
        m_PauseButton.SetActive(false);

        m_UI.SetActive(true);
        m_NGUI.SetActive(false);        
      
    }

    public void Resume()
    {
        Time.timeScale = 1;
        m_PauseButton.SetActive(true);
        m_UI.SetActive(false);
        m_NGUI.SetActive(true);
    }

    public void Exit()
    {
        Time.timeScale = 1;
        int ThemeNum = PlayerPrefs.GetInt("ThemeNum");
        if (ThemeNum == 0)
            SceneManager.LoadScene("Forest");

        else if (ThemeNum == 1)
            SceneManager.LoadScene("Space");

        else if (ThemeNum == 2)
            SceneManager.LoadScene("Parkour");
    }
}
