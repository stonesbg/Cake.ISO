#addin "nuget:?package=Cake.ISO"

Task("Create-ISO")
    .Does(() =>
    {
      var inputDir = "./usageTest";
      var outputDir = "./usageTest.iso";
      var label = "HELLOWORLD";

      CreateIso(inputDir, outputDir, label);
    });

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Create-ISO");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);