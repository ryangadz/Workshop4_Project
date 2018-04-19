// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Workshop4_ProjectEditorTarget : TargetRules
{
	public Workshop4_ProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Workshop4_Project" } );
	}
}
