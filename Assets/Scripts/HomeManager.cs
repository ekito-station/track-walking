using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeManager : MonoBehaviour
{
    Coroutine walkingRecord;
    public float waitSec;

    public GameObject recordButton;
    public GameObject recordStopButton;

    public GameObject arCamera;
    public GameObject spherePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRecordButtonClicked()
    {
        walkingRecord = StartCoroutine("WalkingRecord");
        recordStopButton.SetActive(true);
        recordButton.SetActive(false);
    }

    public void OnRecordStopButtonClicked()
    {
        StopCoroutine(walkingRecord);
        recordButton.SetActive(true);
        recordStopButton.SetActive(false);
    }

    private IEnumerator WalkingRecord()
    {
        while (true)
        {
            PutSphere();
            yield return new WaitForSeconds(waitSec);
        }
    }

    public void PutSphere()
    {
        Vector3 cameraPos = arCamera.transform.position;
        GameObject soundSphere = Instantiate(spherePrefab, cameraPos, Quaternion.identity);
    }
}
