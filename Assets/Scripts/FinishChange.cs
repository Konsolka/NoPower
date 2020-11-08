using UnityEngine;

public class FinishChange : MonoBehaviour
{
	public GameManager gameManger;
	private Transform _sphere;
	private bool _status;
	public GameObject [] wireLines;
	public Material [] material;
	private Renderer _rend;
	private void Start()
	{
		_sphere = gameObject.transform.GetChild(1);
		_rend = _sphere.GetComponent<Renderer>();
		_rend.enabled = true;
		_rend.sharedMaterial = material[0];
		_status = false;
	}
	private void Update()
	{
		if (getWireLineStates() && !_status)
		{
			_status = true;
			_rend.sharedMaterial = material[1];
			gameManger.CompleteLevel();
		}
	}
	private bool getWireLineStates()
	{
		for (int i = 0; i < wireLines.Length; i++)
		{
			if (wireLines[i].tag == "Off")
				return (false);
		}
		return (true);
	}
}
