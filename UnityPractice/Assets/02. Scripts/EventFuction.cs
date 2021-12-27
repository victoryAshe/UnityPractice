using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFuction : MonoBehaviour
{
    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    public IEnumerator stateUpdate()
    {
        yield return new WaitForSeconds(0.03f);
    }
}
