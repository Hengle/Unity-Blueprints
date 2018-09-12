﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlueprintNodeMathSubtractVector2 : BlueprintNodeMath
{
	//Returns the blueprint node math subtract vector2 output attribute
	public override object GetAttribute()
	{
		//If dependent attribute connections are valid
		if (connections[0].connectionNodeID > -1 && connections[1].connectionNodeID > -1)
		{
			//Return output attribute
			return ((Vector2)BlueprintInstanceManager.GetBlueprintAt(blueprintID).GetBlueprintNodeAt(connections[0].connectionNodeID).GetAttribute()) -
				   ((Vector2)BlueprintInstanceManager.GetBlueprintAt(blueprintID).GetBlueprintNodeAt(connections[1].connectionNodeID).GetAttribute());
		}

		//Return default output attribute
		return GetDefaultOutputAttribute();
	}

	//Returns the blueprint node math subtract vector2 default output attribute
	public override object GetDefaultOutputAttribute()
	{
		//Return the blueprint node math subtract vector2 default output attribute
		return new Vector2(0.0f, 0.0f);
	}

//If running in the Unity Editor
#if UNITY_EDITOR
	//Initializes the blueprint node math subtract vector2 instance
	public override void Initialize()
	{
		//Perform base initialization
		base.Initialize();

		//Initialize the blueprint node math subtract vector2
		connections.Add(new BlueprintConnectionAttributeInputVector2());
		connections[connections.Count - 1].Initialize(blueprintID, nodeID, 1, true);
		connections.Add(new BlueprintConnectionAttributeInputVector2());
		connections[connections.Count - 1].Initialize(blueprintID, nodeID, 2, true);
		connections.Add(new BlueprintConnectionAttributeOutputVector2());
		connections[connections.Count - 1].Initialize(blueprintID, nodeID, 1, false);
	}

	//Returns the blueprint node math subtract vector2 title
	protected override string GetTitle()
	{
		//Return the blueprint node math subtract vector2 title
		return "SubtractVector2";
	}

	//Renders the blueprint node math subtract vector2 body components
	protected override void RenderBodyComponents()
	{
		//Render the vector2 label
		BeginSection(1);
			GUILayout.Label("Vector2", BlueprintStyleHelper.GetNodeAttributeTextStyle());
		EndSection();

		//Render the vector2 label
		BeginSection(2);
			GUILayout.Label("Vector2", BlueprintStyleHelper.GetNodeAttributeTextStyle());
		EndSection();
	}
#endif
}