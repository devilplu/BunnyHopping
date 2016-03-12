using UnityEngine;
using System.Collections;

public class BhopBlocksScript : MonoBehaviour {
    public float m_Speed;               //블록이 내려가는 속도

    float m_Depth;                      //얼마나 내려갈 것인지 (블록의 크기만큼 내려감)

    Vector2 m_InitPos;                  //최초 위치

    bool m_Flag;                        //
    bool m_IsOpen;                      //플레이어가 블록에 닿으면 true가 되고 true인동안 블록은 내려갔다가 다시 올라옴

	// Use this for initialization
	void Start () {
        m_InitPos = this.transform.position;
        m_Depth = this.transform.localScale.y;
    }
	
	// Update is called once per frame
	void Update () {
        
        if(m_Flag)
        {
            if (m_IsOpen)
            {
                //버니블록이 아래로 내려감
                this.transform.Translate(Vector2.down * m_Speed * Time.deltaTime);
                //정해진 깊이만큼 내려가고나면 다시 올라옴
                if (Vector2.Distance(m_InitPos, this.transform.position) > m_Depth)
                {
                    m_IsOpen = false;
                }
            }

            //내려간 블록이 다시 올라옴
            else
            {
                this.transform.Translate(Vector2.up * m_Speed * Time.deltaTime);
                if (Vector2.Distance(m_InitPos, this.transform.position) < 0.1f )
                {
                    m_Flag = false;
                    this.transform.position = m_InitPos;
                }
            }
        }
       


    }

    //플레이어가 버니블록을 건드리면
    void OnCollisionStay2D(Collision2D coll)
    {
        m_Flag = true;
        m_IsOpen = true;
    }
}
