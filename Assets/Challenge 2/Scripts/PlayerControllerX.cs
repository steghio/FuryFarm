using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0f;

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) &&  cooldown <= 0.1f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 1f;
        }
    }
}
