using UnityEngine;

namespace Eloi.LowPolyTool { 
    public class LowPolyMono_MaxAngleRotationSet : MonoBehaviour
    {
        public float m_maxAngle = 45f; // Maximum angle in degrees
        public Transform m_whatToMove;
        public Vector3 m_localAxis = Vector3.right;

        [Range(-1,1)]
        public float m_percent = 0; // Percentage of the max angle to apply
        public float m_currentAngle = 0f; // Current angle in degrees

        public bool m_useOnValidate=true;
        
        public void SetWithPercent(float percent)
        {
            m_percent = Mathf.Clamp(percent,-1,1);
            m_currentAngle = m_maxAngle * m_percent;
        }

        public void SetWithDegree(float degree)
        {
            m_currentAngle = Mathf.Clamp(degree, -m_maxAngle, m_maxAngle);
            m_percent = m_currentAngle / m_maxAngle;
        }

        private void OnValidate()
        {

            if (!m_useOnValidate) return;
            SetWithPercent(m_percent);
            Refresh();
        }

        public void Update()
        {
            Refresh();
        }
        public void Refresh() {


            if (m_whatToMove == null ) return;
            Quaternion targetRotation = Quaternion.AngleAxis(m_currentAngle, m_localAxis) ;
            m_whatToMove.localRotation = targetRotation;

        }
    }
}
