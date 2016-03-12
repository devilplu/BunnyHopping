using UnityEngine;
using System.Collections;

public class TeleportZoneScript : MonoBehaviour {
    public GameObject m_TPTarget;        //닿으면 순간이동되는 위치
	
    //객체가 텔레포트존에 닿으면
    void OnTriggerEnter2D(Collider2D other)
    {
        //그 객체가 플레이어면
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.position = m_TPTarget.transform.position;
          
        }
    }

    void OnColliderEnter2D(Collision2D other)
    {

    }
}
