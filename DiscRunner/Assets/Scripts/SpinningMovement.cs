using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
    }
}
