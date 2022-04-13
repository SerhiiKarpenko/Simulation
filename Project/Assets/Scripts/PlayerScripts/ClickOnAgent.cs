using UnityEngine;
using UnityEngine.UI;

public class ClickOnAgent : MonoBehaviour
{
	[SerializeField] private Text _agentHealthPointsText;
	[SerializeField] private Text _agentNameText;
	[SerializeField] private Text _markoPoloText;
	[SerializeField] private GameObject _agentInformationCanvas;
	private GameObject _previousClickedAgent;

	private void Update()
	{
		if(Input.GetButtonDown("Fire1"))
			OnClickOnAgent();
		

		if(_previousClickedAgent != null)
        {
			_agentHealthPointsText.text = "Agent health:" + " " + _previousClickedAgent.GetComponent<AgentHealth>().CurrentHealth;
        }
	}


	// To unselect agent, click anywhere on the red plane
	// Hited Agent change's his color to blue, previous change's his color to green
	private void OnClickOnAgent()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit, 40.0f))
		{
			if(hit.transform.gameObject.GetComponent<AgentStats>() != null)
			{
				_agentInformationCanvas.SetActive(true);
				_markoPoloText.text = MarkoPolo.PrintMarkoPoloText();
				if (_previousClickedAgent != null)
				{
					_previousClickedAgent.GetComponent<AgentSelectedChangeColor>().AgentChangeColorUnSelected();
				}
				hit.transform.gameObject.GetComponent<AgentSelectedChangeColor>().AgentChangeColorSelected();
				_previousClickedAgent = hit.transform.gameObject;
				_agentNameText.text = "Agent name:" + " " + _previousClickedAgent.GetComponent<AgentStats>().Name;
				_agentHealthPointsText.text = "Agent health:" + " " + _previousClickedAgent.GetComponent<AgentHealth>().CurrentHealth;
			}
			else
			{
				if (_previousClickedAgent != null)
				{
					_previousClickedAgent.GetComponent<AgentSelectedChangeColor>().AgentChangeColorUnSelected();
				}
				_agentInformationCanvas.SetActive(false);
			}
		}

	}

}
