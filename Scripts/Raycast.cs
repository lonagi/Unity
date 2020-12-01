RaycastHit hit;
void Update()
{
    //ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
    
    if (Physics.Raycast(dec.Instance.ray, out hit, dec.Instance.range, dec.Instance.Lmask.value))
    {
        if(hit.collider.tag == "item")
        {
            //Obj
            //hit.transform.gameObject
        }
    }
}