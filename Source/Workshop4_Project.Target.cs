// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Workshop4_ProjectTarget : TargetRules
{
	public Workshop4_ProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Workshop4_Project" } );
	}
}
