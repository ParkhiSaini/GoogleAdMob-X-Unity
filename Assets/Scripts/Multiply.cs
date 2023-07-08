using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("add"))
        {
            // other.gameObject.tag = "Finish";
            PlayerManager.PlayerManagerCls.Rblst.Add(other.collider.GetComponent<Rigidbody>());

            other.transform.parent = null;

            other.transform.parent = PlayerManager.PlayerManagerCls.transform;

            other.gameObject.GetComponent<MemberManager>().member = true;

            if (!other.collider.gameObject.GetComponent<Multiply>())
            {
                other.collider.gameObject.AddComponent<Multiply>();
            }

            other.collider.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().material =
                PlayerManager.PlayerManagerCls.Rblst.ElementAt(0).transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().material;
            
            
            
        }
    }
}
