using UnityEngine;

public class LowPolyMono_FromToWithSpeed : MonoBehaviour

{

    public Transform m_from;
    public Transform m_to;
    public Transform m_whatToMove;
    public float m_speed = 1f; 
    void Update()
    {
        if (m_from != null && m_to != null)
        {
            float step = m_speed * Time.deltaTime; // Calculate the step size
            m_whatToMove.position = Vector3.MoveTowards(transform.position, m_to.position, step);
            m_whatToMove.forward = m_from.forward;

            float maxDistance = Vector3.Distance(m_from.position, m_to.position);
            float currentDistance = Vector3.Distance(m_from.position, m_whatToMove.position);
            if (currentDistance >= maxDistance)
            {
                // Reset position to the starting point
                m_whatToMove.position = m_from.position;
            }

        }
    }


}
