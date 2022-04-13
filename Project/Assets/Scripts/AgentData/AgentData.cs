using UnityEngine;

[CreateAssetMenu(menuName = "Agents/New Agent", fileName = "New Agent")]
public class AgentData : ScriptableObject
{
	public string Name;
	public float Speed;
}
