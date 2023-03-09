#!/usr/bin/env dotnet-script
#r "nuget: StateSmith, 0.8.2-alpha"
using StateSmith.Output.Gil;

WriteLine("Started running...");
GilHelper.Compile("public class Blah{}", out var a, out var b);
WriteLine("Finished running.");