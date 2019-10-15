using UnityEngine;
using System.Collections;

public class Mute : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AudioMute()
	{
		AudioListener.volume=0;
	}

	public void AudioOpen()
	{
		AudioListener.volume = 1;
	}
}
