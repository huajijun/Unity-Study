using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
   
   public int speed = 10;

   private Transform target;

   private int wavepointIndex = 0;

   void Start()
   {
        target = WayPoints.points[0];
   }

   void Update() 
   {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed* Time.deltaTime,Space.World);
        if (Vector3.Distance(transform.position,target.position) < 0.2f)
        {
            GetNextWayPoint();
        }

   }

   void GetNextWayPoint()
   {
        Debug.Log(WayPoints.points.Length);
        if (wavepointIndex >= WayPoints.points.Length -1 )
        {
            Destroy(gameObject);
        }
        else {
            wavepointIndex++;
            target = WayPoints.points[wavepointIndex];
        }
   }
}
