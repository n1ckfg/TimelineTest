using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTime : MonoBehaviour {

    public VideoPlayer video;
    public float time = 0f;

    private void Awake() {
        if (video == null) video = GetComponent<VideoPlayer>();
    }

    private void Start() {
        //video.playbackSpeed = 0f;
    }

    private void Update() {
        video.time = time;		
	}

}
