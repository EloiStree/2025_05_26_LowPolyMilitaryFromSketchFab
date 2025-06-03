using UnityEngine;

public class LowPolyMono_FromToInSeconds : MonoBehaviour
{

    public Transform m_from;
    public Transform m_to;
    public Transform m_whatToMove;
    public float m_timeInSeconds;

    
    void Update()
    {

        float timePercent  = Time.time % m_timeInSeconds / m_timeInSeconds;

        if (m_from != null && m_to != null)
        {
            m_whatToMove.position = Vector3.Lerp(m_from.position, m_to.position, timePercent);
            m_whatToMove.rotation = Quaternion.Slerp(m_from.rotation, m_to.rotation, timePercent);
        }
     



    }
}
