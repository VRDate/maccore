//
// This file describes the API that the generator will produce
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
//
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using MonoMac.ObjCRuntime;

namespace MonoMac.Foundation {

	public partial class NSIndexPath {
		[Advice ("Use NSIndexPath.Create (int[]) instead")]
		public NSIndexPath FromIndexes (uint [] indexes)
		{
			if (indexes == null)
				throw new ArgumentNullException ("indexes");

			IntPtr buf = Marshal.AllocHGlobal (4 * indexes.Length);
			for (int i = 0; i < indexes.Length; i++)
				Marshal.WriteInt32 (buf, i * 4, (int) indexes [i]);
			NSIndexPath ret = _FromIndex (buf, indexes.Length);
			Marshal.FreeHGlobal (buf);
			return ret;
		}

		public static NSIndexPath Create (params int [] indexes)
		{
			if (indexes == null)
				throw new ArgumentNullException ("indexes");

			IntPtr buf = Marshal.AllocHGlobal (4 * indexes.Length);
			for (int i = 0; i < indexes.Length; i++)
				Marshal.WriteInt32 (buf, i * 4, indexes [i]);

			NSIndexPath ret = _FromIndex (buf, indexes.Length);
			Marshal.FreeHGlobal (buf);
			return ret;
		}

		public static NSIndexPath Create (params uint [] indexes)
		{
			if (indexes == null)
				throw new ArgumentNullException ("indexes");

			IntPtr buf = Marshal.AllocHGlobal (4 * indexes.Length);
			for (int i = 0; i < indexes.Length; i++)
				Marshal.WriteInt32 (buf, i * 4, (int) indexes [i]);

			NSIndexPath ret = _FromIndex (buf, indexes.Length);
			Marshal.FreeHGlobal (buf);
			return ret;
		}
		
		public uint [] GetIndexes ()
		{
			int n = Length;
			IntPtr buf = Marshal.AllocHGlobal (4 * n);
			uint [] ret = new uint [n];
			for (int i = 0; i < n; i++)
				ret [i] = (uint) Marshal.ReadInt32 (buf, i * 4);
			Marshal.FreeHGlobal (buf);

			return ret;
		}


		public override bool Equals (object obj)
		{
			if (obj == null)
				return false;

			NSIndexPath other = obj as NSIndexPath;
			if (other == null)
				return false;

			return Compare (other) == 0;
		}

		public override int GetHashCode ()
		{
			return Length;
		}
	}
}
