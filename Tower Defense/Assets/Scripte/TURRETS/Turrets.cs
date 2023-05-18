//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Turrets : MonoBehaviour
//{
//    private Transform target;
//    public float range = 15f;

//    public string enemyTag = "Enemy";

//    public Transform partToRotate;


//    // Start is called before the first frame update
//    void Start()
//    {
//        invokeRepeating("UpdateTarget", 0f, 0.5f); 
//    }

//    void UpdateTarget ()
//    {
//        GameObject[] enemies = GameObject.FindGameObjectWithTag(enemyTag);
//        float shortestDistance = Mathf.Infinity;
//        GameObject nearestEnemy = null;
//        foreach (GameObject enemy in enemies) 
//        {
//            float distanceToEnemy = Vector3.Distance (transform.position, enemy.transform.position);
//            if (shoetDistanceToEnemy < shorttestDistance)
//            {
//                shorttestDistance = distanceToEnemy;
//                nearestEnemy = enemy;   
//            }
//        }
//        if (nearestEnemy != null && shortestDistance <= range)
//        {
//            target = nearestEnemy.transform;
//        }
//        else
//        {
//            target = null;
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//    if (target == null)
//         return; 
//        Vector3 Dir = target.position - transform.position;
//        Quaternion lookRotation = Quaternion.LookRotation(dir);
//        Vector3 rotation = lookRotation.eulerAngles; 
//        partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);

//    }

//    void OnDrawGizmosSelected () 
//    {
//        Gizmos.color = Color.blue;
//        Gizmos.DrawWireSphere(transform.position, range);
//    }
//}
