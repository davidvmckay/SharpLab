using System;
using System.Linq.Expressions;

public static class Program {
    public static void Main() {
        Inspect.MemoryGraph(1);
    }
}

/* output

#{"type":"inspection:memory-graph","stack":[{"id":1,"offset":0,"size":4,"title":null,"value":"1"}],"heap":[],"references":[]}

*/