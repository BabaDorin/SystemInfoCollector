using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Documents;

namespace SystemInfoCollector.Models
{

    /// <summary>
    /// Iterates through computer's collections as propertyInfo
    /// </summary>
    class DeviceCollectionPropertyEnumerator : IEnumerator<PropertyInfo>
    {
        private readonly Computer _instance;
        private readonly PropertyInfo[] _collectionOfDeviceLists;
        private int _collectionIndex = -1;

        public DeviceCollectionPropertyEnumerator()
        {
            _instance = Computer.GetInstance();

            _collectionOfDeviceLists = _instance
                .GetType()
                .GetProperties()
                .Where(p => p.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(p.PropertyType))
                .ToArray();
        }

        public PropertyInfo Current => _collectionOfDeviceLists[_collectionIndex] ?? throw new NullReferenceException();

        object IEnumerator.Current => _collectionOfDeviceLists[_collectionIndex] ?? throw new NullReferenceException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_collectionIndex + 1 == _collectionOfDeviceLists.Length)
                return false;

            ++_collectionIndex;
            return true;
        }

        public void Reset()
        {
            _collectionIndex = -1;
        }
    }
}
