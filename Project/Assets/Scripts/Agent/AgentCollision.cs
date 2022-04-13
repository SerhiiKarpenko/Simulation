using UnityEngine;

[RequireComponent(typeof (AgentHealth))]
public class AgentCollision : MonoBehaviour
{
    private AgentHealth _agentHealth;
    private void Start()
    {
        _agentHealth = GetComponent<AgentHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<AgentHealth>() != null)
        {
            _agentHealth.ApplyDamage();
        }
    }
}
