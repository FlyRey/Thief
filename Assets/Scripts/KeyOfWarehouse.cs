using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOfWarehouse : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 40f;

    private void Update()
    {
        gameObject.transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            player.KeyOfWarehouse = true;
            Destroy(gameObject);
        }
    }
}
