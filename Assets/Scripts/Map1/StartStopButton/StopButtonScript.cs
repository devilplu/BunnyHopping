using UnityEngine;
using System.Collections;

public class StopButtonScript : MonoBehaviour {
    
    public Sprite m_ButtonIdle;
    public Sprite m_ButtonPressed;

    public bool m_IsFinished;
    public GameObject m_StartButton;

    SpriteRenderer m_Sprite;

    // Use this for initialization
    void Awake () {
        m_Sprite = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(m_StartButton.GetComponent<StartButtonScript>().m_IsStart)
        {
            m_Sprite.sprite = m_ButtonPressed;
        }
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(m_StartButton.GetComponent<StartButtonScript>().m_IsStart == true)
        {
            m_StartButton.GetComponent<StartButtonScript>().m_IsStart = false;
            m_IsFinished = true;
            m_Sprite.sprite = m_ButtonIdle;
        }
       
        

        
    }
}
