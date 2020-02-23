﻿namespace RPGCore.Packages.Pipeline
{
	/// <summary>
	/// Responcible for loading resources into this project from the project files and processing
	/// the <see cref="ProjectResource"/>.
	/// </summary>
	public abstract class ProjectResourceImportProcessor
	{
		public abstract void ProcessImport(ProjectResourceImporter projectResource);
	}
}
