using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonTutorial : MonoBehaviour {
    public Text m_Tuto;
    string[] m_Text;

    int count = 0;
    public GameObject m_Panel;
    public GameObject m_Player;
    public GameObject Particle;
    public Image Arrow_Down;
    //public GameObject Next;
    public Text ButtonText;

    public UIImageButton m_LeftImageButton;
    public UIImageButton m_RightImageButton;
    public UIImageButton m_JumpImageButton;
    public UIImageButton m_CrouchImageButton;

    public GameObject m_PauseUI;
    public GameObject m_NGUI;
    public GameObject m_PauseButton;
    
    StartButtonScript m_StartButton;

    float m_Timer;
    
	// Use this for initialization
	void Awake () {
        m_Text = new string[]{"Welcome to BunnyHopping World!\n\nThis Game's goal is making shortest lap time." ,                                   /* 0 */
                            "You can make short time by jumping a lot like a bunny! Now, let's begin the Tutorial!",
                            "Your character will move left If you touch this button.\n\nMove your character near the white particle!",
                            "",
                            "Great job!",
                            "Now touch this button and move right to Start button. The Timer will be started If you pass the Start button!",        /* 5 */
                            "",
                            "Good job!!\n\nNow You can see the started timer from top of the screen.",
                            "Now, You can jump if you Touch this button.\n\nMove your character near the white particle again!",
                            "",
                            "Good job!!\n\nAnd finally, you can crouch when you touch this button.\n\nTry to crouch 3 seconds!",                                     /* 10 */
                            "",
                            "Good job. Tutorial about buttons is done. let's learn about blocks now!",
                            "",
        };

        m_StartButton = GameObject.Find("StartButton1").GetComponentInChildren<StartButtonScript>();
	}
	
	// Update is called once per frame
	void Update () {        
        m_Tuto.text = m_Text[count];


        if (!m_PauseUI.activeSelf)
        {
            
            switch (count)
            {
                //시작
                case 0:
                    Time.timeScale = 0;
                    break;

                case 1:
                    break;

                //왼쪽버튼 알려줌
                case 2:
                    Arrow_Down.enabled = true;
                    Arrow_Down.transform.localPosition = m_LeftImageButton.transform.localPosition + new Vector3(25f, 125f, 0f);
                    break;

                //왼쪽으로 이동
                case 3:
                    Time.timeScale = 1;
                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(false);
                    Arrow_Down.enabled = false;

                    Particle.transform.position = new Vector3(-5f, 3f, 0f);
                    if (m_Player.transform.position.x > Particle.transform.position.x - 1 && m_Player.transform.position.x < Particle.transform.position.x + 1)
                    {
                        if (m_Player.transform.position.y > Particle.transform.position.y - 1 && m_Player.transform.position.y < Particle.transform.position.y + 1)
                        {
                            count++;
                        }

                    }
                    break;

                //왼쪽 파티클 도착
                case 4:
                    Time.timeScale = 0;
                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(true);
                    //Particle.SetActive(false);
                    Particle.transform.position = new Vector3(-100f, 3f, 0f);
                    break;

                //스타트버튼 알려줌, 오른쪽 버튼 눌러라
                case 5:
                    Arrow_Down.enabled = true;
                    Arrow_Down.transform.localPosition = m_RightImageButton.transform.localPosition + new Vector3(25f, 125f, 0f);
                    break;

                //오른쪽으로 이동중 
                case 6:
                    Time.timeScale = 1;
                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(false);
                    Arrow_Down.enabled = false;

                    if (m_StartButton.m_IsStart)
                    {
                        count++;
                    }
                    break;

                //타이머 시작된거 알려줌
                case 7:
                    Time.timeScale = 0;
                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(true);
                    break;

                //점프 알려줌
                case 8:
                    Arrow_Down.enabled = true;
                    Arrow_Down.transform.localPosition = m_JumpImageButton.transform.localPosition + new Vector3(25f, 125f, 0f);


                    break;

                //점프해서 하얀 파티클 가기
                case 9:
                    Time.timeScale = 1;

                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(false);
                    Arrow_Down.enabled = false;


                    Particle.transform.position = new Vector3(8f, 4.5f, 0f);
                    if (m_Player.transform.position.x > Particle.transform.position.x - 1 && m_Player.transform.position.x < Particle.transform.position.x + 1)
                    {
                        if (m_Player.transform.position.y > Particle.transform.position.y - 1 && m_Player.transform.position.y < Particle.transform.position.y + 1)
                        {
                            count++;
                        }

                    }

                    break;

                //앉기 알려줌
                case 10:
                    Time.timeScale = 0;

                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(true);

                    Arrow_Down.enabled = true;
                    Arrow_Down.transform.localPosition = m_CrouchImageButton.transform.localPosition + new Vector3(25f, 125f, 0f);

                    break;

                //앉아봐
                case 11:
                    Time.timeScale = 1;
                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(false);
                    Arrow_Down.enabled = false;

                    if (m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().m_Crouch)
                    {
                        m_Timer += Time.deltaTime;
                        if (m_Timer > 3)
                            count++;
                    }
                    else
                    {
                        m_Timer = 0;
                    }

                    break;

                //잘했어 끝
                case 12:
                    Time.timeScale = 0;
                    ButtonText.text = "QUIT";
                    //m_Tuto.enabled = false;
                    //Next.SetActive(false);
                    m_Panel.SetActive(true);
                    break;

            }
        }
	}

    public void ButtonClick()
    {
        count++;

        if(count > 12)
        {
            SceneManager.LoadScene("main");

        }
    }

    public void Pause()
    {
        //일시정지
        Time.timeScale = 0;

        //퍼즈 버튼 비활성화
        m_PauseButton.SetActive(false);
        m_PauseUI.SetActive(true);
        m_Panel.SetActive(false);
        m_NGUI.SetActive(false);

    }

    public void Resume()
    {
        Time.timeScale = 1;
        m_PauseUI.SetActive(false);
        m_PauseButton.SetActive(true);
        m_Panel.SetActive(true);
        m_NGUI.SetActive(true);

    }

    public void Exit()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
