using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSecurity : MonoBehaviour
{
    [SerializeField] private GameObject _security;
    [SerializeField] private Transform _dotOfSpawn;
    void Start()
    {
        GameObject Security = Instantiate(_security, _dotOfSpawn);
        Security.transform.position = _dotOfSpawn.position;
    }
}
