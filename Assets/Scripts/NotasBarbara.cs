using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotasBarbara : MonoBehaviour
{

    public Camera cam = null;
    public LineRenderer lineRenderer;
    private Vector3 mousePos;
    private Vector3 Pos;
    private Vector3 previousPos;
    public List<Vector3> linePosition = new List<Vector3>();
    public float minimunDistance = 0.05f;
    private float distance = 0;

    // [SerializeField] public MaterialPropertyBlock width;


    LineRenderer line;




    int contadorN;


    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            this.gameObject.SetActive(true);

            contadorN++;
        }
        if (contadorN % 2 != 0)
        {
            line.enabled = true;

            CuadernoNotas();
        }
        else
        {
            // line.SetPropertyBlock()
            line.enabled = false;
            //Debug.Log("EScondio");


        }

        void CuadernoNotas()
        {
            if (Input.GetMouseButtonDown(0))
            {
                mousePos = Input.mousePosition;
                //La z siempre positiva
                mousePos.z = 10;
                Pos = cam.ScreenToWorldPoint(mousePos);
                previousPos = Pos;
                linePosition.Add(Pos);

            }
            else
            {
                if (Input.GetMouseButton(0))
                {
                    mousePos = Input.mousePosition;
                    mousePos.z = 10;

                    Pos = cam.ScreenToWorldPoint(mousePos);
                    distance = Vector3.Distance(Pos, previousPos);

                    if (distance >= minimunDistance)
                    {
                        previousPos = Pos;
                        linePosition.Add(Pos);
                        lineRenderer.positionCount = linePosition.Count;
                        lineRenderer.SetPositions(linePosition.ToArray());
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("Borro");
                linePosition.Clear();

            }

        }
    }
}
