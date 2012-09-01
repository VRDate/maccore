//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright 2011, 2012 Xamarin Inc
using System;

namespace MonoMac.CoreData {

        public enum NSEntityMappingType : uint {
                Undefined = 0x00,
                Custom = 0x01,
                Add = 0x02,
		Remove = 0x03,
		Copy = 0x05,
		Transform = 0x06
        }

	public enum NSAttributeType : uint {
		Undefined = 0,
		Integer16 = 100,
		Integer32 = 200,
		Integer64 = 300,
		Decimal = 400,
		Double = 500,
		Float = 600,
		String = 700,
		Boolean = 800,
		Date = 900,
		Binary = 1000,
		Transformable = 1800    
	}

	[Flags]
	public enum NSFetchRequestResultType : uint {
		ManagedObject = 0x00,
		ManagedObjectID = 0x01,
		DictionaryResultType = 0x02,
		NSCountResultType = 0x04
	}

	public enum NSKeyValueSetMutationKind : uint {
		Union = 1,
		Minus = 2,
		Intersect = 3,
		NSKeyValueSet = 4
	}

	public enum NSDeleteRule : uint {
		NoAction,
		Nullify,
		Cascade,
		Deny
	}

	public enum NSPersistentStoreRequestType {
		Fetch = 1,
		Save
	}

	public enum NSManagedObjectContextConcurrencyType {
		Confinement, PrivateQueue, MainQueue
	}

	public enum NSMergePolicyType {
		Error, PropertyStoreTrump, PropertyObjectTrump, Overwrite, RollbackMerge
	}
}
