using UnityEngine;

[RequireComponent(typeof(AgentStats))]
public class AgentHealth : MonoBehaviour
{
    private int _currentHealth;
    public int CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = GetComponent<AgentStats>().MaxHealthPoints;
    }

    public void ApplyDamage()
    {
        _currentHealth--;
        if(_currentHealth <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
    }


}
