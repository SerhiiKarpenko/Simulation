using UnityEngine;

public class AgentStats : MonoBehaviour
{
	[SerializeField] private int _healthPoints;
	[SerializeField] private float _speed;

	public int HealthPoints => _healthPoints;
	public float Speed => _speed;
}
