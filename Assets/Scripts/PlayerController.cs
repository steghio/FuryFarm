using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float xRange = 15f;
    [SerializeField] private GameObject projectilePrefab;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Prototype 2");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
