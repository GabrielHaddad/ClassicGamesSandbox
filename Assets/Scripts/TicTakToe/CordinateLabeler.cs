using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
[RequireComponent(typeof(TextMeshPro))]
public class CordinateLabeler : MonoBehaviour
{
    [SerializeField] Color occupiedColor = Color.red;
    [SerializeField] Color availableColor = Color.white;
    
    TextMeshPro label;
    Waypoint waypoint;
    Vector2Int coordinates = new Vector2Int();

    void Awake() 
    {
        label = GetComponent<TextMeshPro>();
        label.enabled = false;

        waypoint = GetComponentInParent<Waypoint>();
        DisplayCoordinates();
    }
   
    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
            label.enabled = true;
        }

        UpdateTextColor();
        ToggleLabels();
    }

    void ToggleLabels()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            label.enabled = !label.IsActive();
        }
    }

    void DisplayCoordinates()
    {
        Vector3 unityGridSize = UnityEditor.EditorSnapSettings.move;
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / unityGridSize.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / unityGridSize.z);

        label.text = $"{coordinates.x},{coordinates.y}";
    }

    void UpdateTextColor()
    {
        /*
        if (waypoint.IsPlaceble)
        {
            label.color = availableColor;
        }
        else
        {
            label.color = occupiedColor;
        }
        */
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
