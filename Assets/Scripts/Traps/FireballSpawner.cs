using System;
using System.Collections;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fireBall;
    [SerializeField] private float shootDelay;
    private GameObject _launchedFireball;

    private void Start()
    {
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootDelay);
            _launchedFireball = Instantiate(fireBall);
            _launchedFireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
            _launchedFireball.transform.rotation = transform.rotation;

        }
    }
}
