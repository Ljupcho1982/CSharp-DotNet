using System.Collections.Generic;

using System.Linq;

List<int> collection =new List<int>() { 1,2, 3 };

IEnumerable<float> collectionOfFloats=collection.Cast<float>();

