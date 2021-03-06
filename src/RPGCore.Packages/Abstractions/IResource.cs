﻿namespace RPGCore.Packages
{
	public interface IResource
	{
		string Name { get; }
		string FullName { get; }
		string Extension { get; }
		IResourceTags Tags { get; }
		IDirectory Directory { get; }
		IResourceDependencyCollection Dependencies { get; }
		IResourceDependencyCollection Dependants { get; }
		IExplorer Explorer { get; }
		IResourceContent Content { get; }
	}
}
