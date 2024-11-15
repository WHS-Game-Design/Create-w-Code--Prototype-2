using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject projectile;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) Instantiate(projectile, transform.position + new Vector3(0, 0, 3), projectile.transform.rotation);
        GetComponent<CharacterController>().Move(new Vector3(Input.GetAxis("Horizontal") * 15 * Time.deltaTime, 0, 0));
    }
}
