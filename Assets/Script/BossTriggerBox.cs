using UnityEngine;
using UnityEngine.Playables;

public class BossTriggerBox : MonoBehaviour 
{
	GameObject timeLine;
	void Start()
	{
		if (GameObject.Find("TimeLine"))
		{
			timeLine = GameObject.Find("TimeLine");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		PlayableDirector pd = timeLine.GetComponent<PlayableDirector>();
		pd.Play();
	}
}
