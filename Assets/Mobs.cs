using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobs : MonoBehaviour
{
    [SerializeField] GameObject[] fruitPrefab;

    [SerializeField] float secondSpawn = 0.1f;

    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    void Start()
    {
        StartCoroutine(FruitSpawn());
    }

    IEnumerator FruitSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(fruitPrefab[Random.Range(0, fruitPrefab.Length)],
                position, Quaternion.identity);
            gameObject.tag = "Square";
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 2f);

        }
    }
}
