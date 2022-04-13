using UnityEngine;

public class AgentStats : MonoBehaviour
{
	[SerializeField] private string _name;
	[SerializeField] private int _maxHealthPoints;
	[SerializeField] private float _speed;

	public string Name => _name;
	public int MaxHealthPoints => _maxHealthPoints;
	public float Speed => _speed;

}
