using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkWaterController : MonoBehaviour
{
    public GameObject Water;
    private bool isWaterOn = false;

    void Start()
    {
        // set the water object to inactive
        if (Water != null)
        {
            Water.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // check if there if the player touches the sink
        if (other.CompareTag("Left Hand") || other.CompareTag("Right Hand"))
        {
            StartWater();
        }
    }

    private void StartWater()
    {
        if (isWaterOn == false)
        {
            isWaterOn = true;
            Water.SetActive(true); // turn on the water
            StartCoroutine(WaterTimer()); // start a timer for 5 seconds
        }
    }

    private IEnumerator WaterTimer()
    {
        yield return new WaitForSeconds(5); // wait for 5 seconds
        Water.SetActive(false); // turn off the water
        isWaterOn = false;
    }
}
