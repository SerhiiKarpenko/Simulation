using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkoPolo : MonoBehaviour
{
	public static string PrintMarkoPoloText()
	{
		string marcoPolo = "";
		for (int i = 1; i <= 100; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				marcoPolo += " MarkoPolo ";
			}
			else if (i % 5 == 0)
			{
				marcoPolo += " Polo ";
			}
			else if (i % 3 == 0)
			{
				marcoPolo += " Marco ";
			}
			else
			{
				marcoPolo += " " + i + " ";
			}
			marcoPolo += ",";
		}
		return marcoPolo;
	}
}
