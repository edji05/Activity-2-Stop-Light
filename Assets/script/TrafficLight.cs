using System.Collections;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public GameObject greenLight;
    public GameObject yellowLight;
    public GameObject redLight;

    void Start()
    {
        StartCoroutine(LightCycle());
    }

    IEnumerator LightCycle()
    {
        while (true)
        {
            // GREEN ON
            greenLight.SetActive(true);
            yellowLight.SetActive(false);
            redLight.SetActive(false);
            yield return new WaitForSeconds(5f);

            // YELLOW ON
            greenLight.SetActive(false);
            yellowLight.SetActive(true);
            redLight.SetActive(false);
            yield return new WaitForSeconds(2f);

            // RED ON
            greenLight.SetActive(false);
            yellowLight.SetActive(false);
            redLight.SetActive(true);
            yield return new WaitForSeconds(5f);
        }
    }
}
