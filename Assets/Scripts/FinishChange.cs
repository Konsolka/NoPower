using UnityEngine;

public class FinishChange : MonoBehaviour
{
	public GameManager gameManger;
	private Transform _sphere;
	public Material sphereMaterial;
	private bool _status;
	public GameObject [] wireLines;
	private Renderer _rend;
	private void Start()
	{
		_sphere = gameObject.transform.GetChild(1);
		_rend = _sphere.GetComponent<Renderer>();
		sphereMaterial.SetColor("Color_12C89509", Color.red);
		_rend.sharedMaterial = sphereMaterial;
		_rend.enabled = true;
		_status = false;
	}
	private void Update()
	{
		if (getWireLineStates() && !_status)
		{
			_status = true;
			sphereMaterial.SetColor("Color_12C89509", Color.green);
			// _rend.sharedMaterial = material[1];
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
