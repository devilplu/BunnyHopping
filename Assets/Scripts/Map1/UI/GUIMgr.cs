using UnityEngine;
using System.Collections;

public class GUIMgr : MonoBehaviour {

    public GameObject m_Player;

	public void RightBtnOnPress()
    {
        m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().h = 1;    
    }

    public void LeftBtnOnPress()
    {
        m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().h = -1;
    }

    public void JumpBtnOnPress()
    {
        m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().m_Jump = true;
    }

    public void CrouchBtnOnPress()
    {
        m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().m_Crouch = true;
    }

    public void CrouchBtnOnRelease()
    {
        m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().m_Crouch = false;
    }

    public void OnRelease()
    {
        m_Player.GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().h = 0;
    }
}
