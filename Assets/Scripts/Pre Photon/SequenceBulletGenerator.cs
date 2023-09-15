using PrePhoton;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SequenceBulletGenerator : MonoBehaviour
{
    [SerializeField] KeyCode manualActivateKey = KeyCode.U;
    [SerializeField] float timeBetweenBulletLaunches;

    [SerializeField] Transform[] sequencePositions;
    [SerializeField] GameObject bullet;

    [SerializeField] float bulletSpeed;

    private void Update()
    {
        if (Input.GetKeyDown(manualActivateKey))
        {
            Activate();
        }
    }

    public void Activate()
    {
        StartCoroutine(ActiveBulletSequence());
    }

    IEnumerator ActiveBulletSequence()
    {
        int len = sequencePositions.Length;
        for (int i = 0; i < len; i++)
        {
            LaunchBullet(i);
            yield return new WaitForSeconds(timeBetweenBulletLaunches);           
        }
    }

    void LaunchBullet(int bulletIndex)
    {
        Vector3 position = sequencePositions[bulletIndex].position;
        Vector3 direction = sequencePositions[bulletIndex].right;
        direction.Normalize();

        GenerateBullet(position, direction);
    }

    void GenerateBullet(Vector3 position, Vector2 direction)
    {
        GameObject newBullet = Instantiate(bullet, position, Quaternion.identity, BulletDisposer.instance.transform);
        newBullet.GetComponent<Bullet>().movementVector = direction * bulletSpeed;
    }
}
