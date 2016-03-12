using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollRectSnap : MonoBehaviour {

    public RectTransform m_Panel;       //스크롤패널
    public Button[] m_Btn;
    public RectTransform m_Center;      //각 버튼의과 거리 비교용 변수

    private float[] m_Distance;
    private bool m_Dragging = false;
    private int m_BtnDistance;
    private int m_MinBtnNum;

    void Start()
    {
        int btnLength = m_Btn.Length;
        m_Distance = new float[btnLength];

        //버튼들로부터 거리를 구함
        m_BtnDistance = (int)Mathf.Abs(m_Btn[1].GetComponent<RectTransform>().anchoredPosition.x
            - m_Btn[0].GetComponent<RectTransform>().anchoredPosition.x);
        //print(m_BtnDistance);

    }

    void Update()
    {
        for(int i = 0; i<m_Btn.Length; ++i )
        {
            m_Distance[i] = Mathf.Abs(m_Center.transform.position.x -
                m_Btn[i].transform.position.x);
        }

        //최단거리 구하기
        float minDistance = Mathf.Min(m_Distance);

        for(int a=0; a<m_Btn.Length; ++a)
        {
            if(minDistance == m_Distance[a])
            {
                m_MinBtnNum = a;
            }
        }

        if(!m_Dragging)
        {
            LerpToBtn(m_MinBtnNum * -m_BtnDistance);
        }
    }

    void LerpToBtn(int position)
    {
        float newX = Mathf.Lerp(m_Panel.anchoredPosition.x, position, Time.deltaTime * 10f);
        Vector2 newPosition = new Vector2(newX, m_Panel.anchoredPosition.y);

        m_Panel.anchoredPosition = newPosition;
    }

    public void StartDrag()
    {
        m_Dragging = true;
    }

    public void EndDrag()
    {
        m_Dragging = false;
    }
}
