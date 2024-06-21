using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TrackGenerator: MonoBehaviour
{
    public Transform currentTrackGeneratorPoint;
    public List<TrackPart> trackPrefabs;
    public CreateTrackTrigger createTrackTrigger;

    private void OnEnable()
    {
        createTrackTrigger.Collided += CreateTrackPart;
    }

    private void OnDisable()
    {
        createTrackTrigger.Collided -= CreateTrackPart;
    }

    private void CreateTrackPart()
    {
        int randomTrackPartIndex = Random.Range(0, trackPrefabs.Count);
        TrackPart currentCreatingTrackPart = Instantiate(trackPrefabs[randomTrackPartIndex], currentTrackGeneratorPoint.position, currentTrackGeneratorPoint.rotation);
        
        Destroy(createTrackTrigger.gameObject);
        createTrackTrigger = currentCreatingTrackPart.createTrackTrigger;
        createTrackTrigger.Collided += CreateTrackPart;

    }
}
