using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private bool isProjectile;

    void Update() => transform.Translate(Vector3.forward * new Vector3(isProjectile ? 25 : Random.Range(3, 15), 0, 0).magnitude * Time.deltaTime);
    void OnTriggerEnter(Collider collider) => Destroy(gameObject);
}
