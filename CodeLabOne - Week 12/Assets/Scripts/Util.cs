using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathUtil //why use namespace?
    //if you're in a large project,
    //and if there are two scripts that are the same name
    //having a namespace will prevent confusion between those scripts. 
    
    //THE DOT PRODUCT!?
    //The angle between two lines
    //the first line is the direction the object is facing.
    //the second is going to the line between the player and the object. 
    //DOT is going to find the angle between the two. 
{
    public class Util: MonoBehaviour
        {
        public static bool CanSeeObj(GameObject destination, GameObject origin, float range)
        {
            Vector3 dir = Vector3.Normalize(destination.transform.position - origin.transform.position); //destination will become the player.
            float angleDist = Vector3.Dot(origin.transform.forward, dir);

            Debug.DrawRay(origin.transform.position, origin.transform.forward * 10, Color.red);
            Debug.DrawRay(origin.transform.position, dir * 10, Color.green);

            if (angleDist > range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Vector3 ObjSide(GameObject destination, GameObject origin)
        {
            Vector3 dir = Vector3.Normalize(destination.transform.position - origin.transform.position);
            Vector3 crossProd = Vector3.Cross(origin.transform.forward, dir);
            Debug.Log(crossProd);
            if(crossProd.y < 0)
            {
                Debug.Log(destination.name + " is left of " + origin.name);
            }
            else
            {
                Debug.Log(destination.name + " is right of " + origin.name);
            }
            return crossProd;
        }

        }
}
