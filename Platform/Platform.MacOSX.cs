﻿namespace ZeroMQ.lib
{

	public static partial class Platform
	{
		public static class MacOSX
		{

			// public const string LibraryFileExtension = ".dylib";

			public static readonly string[] LibraryPaths = new string[] {
<<<<<<< HEAD
                "/usr/lib/{LibraryName}.dylib",
                "/usr/local/lib/{LibraryName}.dylib.*",
=======
>>>>>>> 0038133f4f306d8bdf880b284d7b51341d875646
                "{DllPath}/{LibraryName}.dylib",
                "{DllPath}/{LibraryName}.dylib.*",
                "{Path}/{LibraryName}.dylib",
                "{Path}/{LibraryName}.dylib.*",
				"{AppBase}/{Arch}/{LibraryName}.dylib",
				"{AppBase}/{Arch}/{LibraryName}.dylib.*",
            };

		}
	}
}
