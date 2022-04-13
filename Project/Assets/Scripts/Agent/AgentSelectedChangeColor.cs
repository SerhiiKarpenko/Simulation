using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSelectedChangeColor : MonoBehaviour
{
    public void AgentChangeColorSelected()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(0,0,255);
    }

    public void AgentChangeColorUnSelected()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 255, 0);
    }
}
