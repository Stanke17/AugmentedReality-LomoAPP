using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StartScript : MonoBehaviour, ITrackableEventHandler
{
    public GameObject video;
    private TrackableBehaviour mtrackableBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        video.SetActive(false);
        mtrackableBehaviour = GetComponent<TrackableBehaviour>();
        if(mtrackableBehaviour)
        {
            mtrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if(newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            video.SetActive(true);
        }
        else
        {
            video.SetActive(false);
        }
    }
}
