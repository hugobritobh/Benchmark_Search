using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Collections.Immutable;

namespace Common
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class BenchmarkSearchString
    {
        private string _containsStartKey;
        private string _containsHalfKey;
        private string _containsEndKey;

        private HashSet<string> _hash;
        private List<string> _list;
        private Dictionary<string, bool> _dic;
        private ImmutableHashSet<string> _immutHash;
        private ImmutableSortedSet<string> _immutSorted;
        private ImmutableSortedDictionary<string, bool> _immutDic;
        private ImmutableList<string> _immutList;
        private ImmutableArray<string> _immutArray;
        private ReadOnlyMemory<string> _memory;

        [GlobalSetup]
        public void Setup()
        {
            //Numero par
            int num = 1000;
            _list = new List<string>(num);
            _dic = new Dictionary<string, bool>(num);
            _hash = new HashSet<string>(num);

            for (int i = 0; i < num; i++)
            {
                //Simulando uma chave do tipo string
                var key = i.ToString() + "_" + i.ToString();
                _list.Add(key);
                _dic.Add(key, true);
                _hash.Add(key);
            }

            var half = num / 2;
            _containsHalfKey = $"{half}_{half}";
            _containsStartKey = $"{50}_{50}";
            _containsEndKey = $"{num - 1}_{num - 1}";

            _list.Sort();

            _immutHash = _list.ToImmutableHashSet();
            _immutSorted = _list.ToImmutableSortedSet();
            _immutDic = _dic.ToImmutableSortedDictionary();
            _immutList = _list.ToImmutableList();
            _immutArray = _list.ToImmutableArray();

            _memory = _immutArray.AsMemory();
        }

        private int _cont = 0;

        /// <summary>
        /// Chave Random (3 keys)
        /// </summary>
        /// <returns></returns>
        private string GetKey()
        {
            Interlocked.Increment(ref _cont);

            if (_cont == 1)
            {
                return _containsHalfKey;
            }
            else if (_cont == 2)
            {
                return _containsEndKey;
            }

            _cont = 0;
            return _containsStartKey;
        }

        [Benchmark]
        public void MemorySpanBinarySearch()
        {
            var key = GetKey();
            var result = _memory.Span.BinarySearch(key);
        }

        [Benchmark]
        public void MemorySpanIndexOf()
        {
            var key = GetKey();
            var result = _memory.Span.IndexOf(key);
        }

        [Benchmark]
        public void HashContains()
        {
            var key = GetKey();
            var result = _hash.Contains(key);
        }

        [Benchmark]
        public void ListContains()
        {
            var key = GetKey();
            var result = _list.Contains(key);
        }

        [Benchmark]
        public void ListAny()
        {
            var key = GetKey();
            var result = _list.Any(i => i == key);
        }

        [Benchmark]
        public void ImmutHash()
        {
            var key = GetKey();
            var result = _immutHash.Contains(key);
        }

        [Benchmark]
        public void ImmutArrayContains()
        {
            var key = GetKey();
            var result = _immutArray.Contains(key);
        }

        [Benchmark]
        public void ImmutSorted()
        {
            var key = GetKey();
            var result = _immutSorted.Contains(key);
        }

        [Benchmark]
        public void DicContains()
        {
            var key = GetKey();
            var result = _dic.ContainsKey(key);
        }

        [Benchmark]
        public void ImmutSortedDicContains()
        {
            var key = GetKey();
            var result = _immutDic.ContainsKey(key);
        }

        [Benchmark]
        public void ImmutListContains()
        {
            var key = GetKey();
            var result = _immutList.Contains(key);
        }

        [Benchmark]
        public void ImmutListBinarySearch()
        {
            var key = GetKey();
            var result = _immutList.BinarySearch(key);
        }

        ///VERY SLOW
        [Benchmark]
        public void ImmutListAny()
        {
            var key = GetKey();
            var result = _immutList.Any(i => i == key);
        }
    }

}
