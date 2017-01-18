using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {
    public GameObject player;
    public Vector3 TrackOffset;
	// Use this for initialization
	void Start () {

        TrackOffset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    //late update is called after the usual update, per frame
    //for follow cameras, procedural animation AND FOR GATHERING LAST KNOWN STATES, its best to use lateUpdate
	void LateUpdate () {

        transform.position = player.transform.position + TrackOffset;
	}
}
