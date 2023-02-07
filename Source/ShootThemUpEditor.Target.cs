// Shoot Them Up Game. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootThemUpEditorTarget : TargetRules
{
	public ShootThemUpEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ShootThemUp" } );

		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_0; //Mashuk: "There was an error about UE version, I changed it to 5_1",
                                                                   //Mashuk: "Later I had a problem with 'FDamageEvent' in 'TakeDamage', so I brought back a 5_0 value"

    }
}
