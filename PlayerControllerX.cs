using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer > 2)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Debug.Log(timer);

            timer = 0;
        }
    }
}
