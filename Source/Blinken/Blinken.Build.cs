// Copyright (C) 2016 Descendent Studios, Inc.

using UnrealBuildTool;
using System.IO;

 public class Blinken : ModuleRules
{
	public Blinken(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange( new string[] { "Engine", "Core", "InputCore", "CoreUObject" } ); 

		if(Target.Platform == UnrealTargetPlatform.Win64)
		{
			// AlienFX SDK
			PublicIncludePaths.Add( Path.GetFullPath(Path.Combine(ModuleDirectory, "../../ThirdParty/AlienFXSDK/includes") )
				);
		}
	}
}
