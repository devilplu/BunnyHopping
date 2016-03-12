using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(PlatformerCharacter2D))]

    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        
        public bool m_Jump;
        public bool m_Crouch;

        public float h;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();     
        }

        private void Update()
        {
            if (m_Jump)
            {
                m_Character.m_JumpDelay = 0;
            }
        }


        private void FixedUpdate()
        {
            m_Character.Move(h, m_Crouch, m_Jump);
            m_Jump = false;
        }
    }
}
