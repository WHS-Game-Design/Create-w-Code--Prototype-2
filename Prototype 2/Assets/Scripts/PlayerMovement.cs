using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private readonly float speedNormal = 30;
    private readonly float speedPowerUp = 60;
    private readonly int limitX = 15;

    [SerializeField] private GameObject projectilePrefab;

    private bool powerUpIsActive;

    void Update()
    {
        float speed = powerUpIsActive ? speedPowerUp : speedNormal;

        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(Time.deltaTime * speed * inputX * Vector3.right);

        transform.position = Vector3.ClampMagnitude(transform.position, limitX);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(nameof(PowerUp));
        }
    }

    IEnumerator PowerUp()
    {
        powerUpIsActive = true;
        yield return new WaitForSeconds(7);
        powerUpIsActive = false;
    }
}
