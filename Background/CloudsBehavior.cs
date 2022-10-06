using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsBehavior : MonoBehaviour
{
    [SerializeField] float speedCloudFly, biasXSpaunPoint, baisZSpaunPoint;
    [SerializeField] Transform parentObject, characterObject;
    [SerializeField] Vector3 destroyPoint;

    Vector3 spaunPoint;

    private void Update()
    {
        MoveRight();
        SpaunCloud();
        DestroyCloud();
    }

    void MoveRight()
    {
        transform.Translate(Vector3.left * speedCloudFly * Time.deltaTime);
        spaunPoint = new Vector3(characterObject.position.x + biasXSpaunPoint, characterObject.position.y, characterObject.position.z - baisZSpaunPoint);
    }

    void SpaunCloud()
    {
        if (transform.position.x <= destroyPoint.x)
            Instantiate(gameObject, spaunPoint, Quaternion.identity, parentObject);
    }

    void DestroyCloud()
    {
        if (transform.position.x <= destroyPoint.x)
            Destroy(gameObject);
    }
}
