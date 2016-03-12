using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;


public class StartButtonScript : MonoBehaviour {

    public GameObject m_Player;
    public GameObject m_StopButton;

    public float m_Record;
    public float m_Timer;
    public float m_TimerMinute;
    public bool m_IsStart;

    public Sprite m_ButtonIdle;
    public Sprite m_ButtonPressed;

    public String m_FinishTime;

    public Text m_Text;
    public GameObject m_NewRecord;
    SpriteRenderer m_Sprite;

    public GameObject m_FinishedUI;
    public GameObject m_NGUI;

    public GameObject m_VelocityUI;
    public GameObject m_TimerUI;
    public GameObject m_PauseUI;

	// Use this for initialization
	void Awake () {
        //m_Text = GameObject.Find("Timer").GetComponentInChildren<Text>();
        m_Sprite = GetComponent<SpriteRenderer>();
        m_NewRecord.SetActive(false);

        //디버깅용
        //PlayerPrefs.SetFloat("f" + this.name, 0);
        //PlayerPrefs.SetString(this.name, null);

    }
	
	// Update is called once per frame
	void Update () {
        //타이머 시작
        if (m_IsStart)
        {
            m_Record += Time.deltaTime;                                               //최고기록 측정용 변수 (초만 계산)
            m_Timer += Time.deltaTime;                                                //시간 측정
          
            if(m_Timer >= 60.0f)
            {
                m_TimerMinute++;
                m_Timer -= 60.0f;  
            }
            m_Text.text = m_TimerMinute.ToString("00") + ":" + (Math.Round(m_Timer, 2)).ToString("00.00");
            
        }
        else
        {           
            m_Sprite.sprite = m_ButtonIdle;

            //타이머가 시작됬다가 종료된 경우
            if(m_StopButton.GetComponent<StopButtonScript>().m_IsFinished)
            {
                //끝나고 나오는 UI에 피니쉬타임 보여줌
                m_FinishedUI.SetActive(true);
                m_FinishedUI.GetComponent<FinishedUI>().m_FinishTime.text = m_Text.text;
                //이동 버튼 끔
                m_NGUI.SetActive(false);
                //플레이어 멈추게함
                m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().h = 0;
                //velocity, timer, pause UI 전부 끔
                m_VelocityUI.SetActive(false);
                m_TimerUI.SetActive(false);
                m_PauseUI.SetActive(false);


                //기존 기록이 0이거나 (기록이 없거나) 기존 기록보다 새 기록이 더 빠르면
                if (PlayerPrefs.GetFloat("f"+this.name) == 0 || PlayerPrefs.GetFloat("f"+this.name) > m_Record)
                {
                    m_FinishTime = m_Text.text;
                    m_NewRecord.SetActive(true);
                    PlayerPrefs.SetFloat("f"+this.name, m_Record);
                    PlayerPrefs.SetString(this.name, m_FinishTime);             //피니쉬 타임 저장
                    Debug.Log("test");
                }
                

                
            }
        }
        //Debug.LogFormat("m_Record : {0}", m_Record);
        //Debug.Log("GetFloat : " + PlayerPrefs.GetFloat("f"+this.name));
        //Debug.Log("GetString : " + PlayerPrefs.GetString(this.name));
        

    }

    void OnTriggerExit2D(Collider2D other)
    {
        m_IsStart = true;
        m_Sprite.sprite = m_ButtonPressed;                                  //버튼 스프라이트를 눌린 거로 바꿈
        m_Text.enabled = true;                                              //화면 상단에 시간초 나옴
    }
}


