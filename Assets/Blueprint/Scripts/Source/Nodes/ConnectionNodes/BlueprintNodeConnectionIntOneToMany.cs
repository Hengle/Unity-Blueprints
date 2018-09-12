﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlueprintNodeConnectionIntOneToMany : BlueprintNodeConnection
{
	//Returns the blueprint node connection int one to many default output attribute
	public override object GetDefaultOutputAttribute()
	{
		//Return the blueprint node connection int one to many default output attribute
		return 0.0f;
	}

//If running in the Unity Editor
#if UNITY_EDITOR
	//Initializes the blueprint node connection int one to many instance
	public override void Initialize()
	{
		//Perform base initialization
		base.Initialize();

		//Initialize the blueprint node connection int one to many
		connections.Add(new BlueprintConnectionAttributeInputInt());
		connections[connections.Count - 1].Initialize(blueprintID, nodeID, 1, true);
		AddOutputConnection<BlueprintConnectionAttributeOutputInt>();
	}

	//Returns the blueprint node connection int one to many title
	protected override string GetTitle()
	{
		//Return the blueprint node connection int one to many title
		return "IntOneToMany";
	}

	//Renders the blueprint node connection int one to many body components
	protected override void RenderBodyComponents()
	{
		//Render the blueprint node connection int one to many body components for a blueprint connection output int
		RenderBodyComponentsOneToMany<BlueprintConnectionAttributeOutputInt>();
	}
#endif
}