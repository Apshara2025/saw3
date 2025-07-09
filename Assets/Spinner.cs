using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationAmount = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate a bit every update
        transform.Rotate(0, 0, rotationAmount);
    }
}
