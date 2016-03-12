using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class FinishedUI : MonoBehaviour {
    
    public Text m_FinishTime;
    //public GameObject[] m_StartButton;
    //public GameObject[] m_StopButton;
    //public GameObject m_Player;
    //public GameObject m_NGUI;
    //public GameObject m_VelocityUI;
    //public GameObject m_TimerUI;
    //public GameObject m_PauseUI;

  
    public void Again()
    {
        //for(int i=0; i<m_StopButton.Length; ++i)
        //{
        //    m_StopButton[i].GetComponent<StopButtonScript>().m_IsFinished = false;
        //}

        //for (int i = 0; i < m_StartButton.Length; ++i)
        //{
        //    m_StartButton[i].GetComponent<StartButtonScript>().m_Timer = 0;
        //    m_StartButton[i].GetComponent<StartButtonScript>().m_Record = 0;
        //    m_StartButton[i].GetComponent<StartButtonScript>().m_Text.text = null;
        //    m_StartButton[i].GetComponent<StartButtonScript>().m_NewRecord.SetActive(false);
        //}


        //m_NGUI.SetActive(true);

        ////플레이어 위치를 시작 지점으로 이동
        //int StartMap = PlayerPrefs.GetInt("StartMap");
        //m_Player.transform.position = m_Player.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_StartPos[StartMap].transform.position;

        ////UI 다시 킴
        //m_VelocityUI.SetActive(true);
        //m_TimerUI.SetActive(true);
        //m_PauseUI.SetActive(true);
        SceneManager.LoadScene("map1");


        this.gameObject.SetActive(false);

    }

    public void Exit()
    {
        SceneManager.LoadScene("ChooseMap");
    }
}
