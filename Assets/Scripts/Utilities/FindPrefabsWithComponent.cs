using UnityEngine;
using System.Collections;

public class FindPrefabsWithComponent : MonoBehaviour {
	
	public GameObject[] prefabs;

	void Start()
	{
		FindPrefabsWithComponentType<Rigidbody>();
	}
	
	private void FindPrefabsWithComponentType<T>() where T : Component
	{
		Debug.Log("Searching for components");
		foreach (var prefab in prefabs)
		{
			T foundComponent = prefab.GetComponentInChildren<T>();
			if (foundComponent != null)
			{
				Debug.Log("Found component in " + foundComponent.name);
			}
		}
		Debug.Log("search complete");
	}
}