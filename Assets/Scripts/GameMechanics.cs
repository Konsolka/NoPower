using UnityEngine;

public class GameMechanics : MonoBehaviour
{
	public void changeTag(GameObject []wireLine, string str)
	{
		for (int i = 0; i < wireLine.Length; i++)
			wireLine[i].tag = str;
	}
	public bool getWireLineStatesAndGate(GameObject []wireLine)
	{
		for (int i = 0; i < wireLine.Length; i++)
		{
			if (wireLine[i].tag == "Off")
				return (false);
		}
		return (true);
	}
	public bool getWireLineStatesOrGate(GameObject []wireLine)
	{
		for (int i = 0; i < wireLine.Length; i++)
		{
			if (wireLine[i].tag == "On")
				return (true);
		}
		return (false);
	}
	public bool getWireLineStatesXorGate(GameObject [] wireLine)
	{
		bool xor;

		xor = wireLine[0].tag == "On" ? true : false;
		for (int i = 1; i < wireLine.Length; i++)
		{
			xor ^= wireLine[i].tag == "On" ? true : false;
		}
		return (xor);
	}
	public void changeWireLine(GameObject gameobj, Material material)
	{
		Renderer rend;
		for (int i = 0; i < gameobj.transform.childCount; i++)
		{
				Transform child = gameobj.transform.GetChild(i).GetChild(1);
				rend = child.GetComponent<Renderer>();
				rend.sharedMaterial = material;
		}
	}
}
