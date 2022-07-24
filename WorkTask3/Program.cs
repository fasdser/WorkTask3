using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask3
{
     class Program
    {
        static void Main(string[] args)
        {
            var s = new Tree();
            Tree tree = new Tree();
            tree.Name = "Lelik";
            Tree tree1 = new Tree();
            tree1.Name = "Bolik";
            s.Add(tree1);
            s.Add(tree);                      
            //s.Children.Add(new Tree("asdasd"));
            //s.Children.Add(new Tree("asdsaa"));
            foreach (var item in s.Children)
            Console.WriteLine(item);
            Console.ReadLine();
        }
    }

    class Tree
    {
        public string Name { get; set; }

        public IEnumerable<Tree> Children { get; set; }

        public Tree(string name)
        {
            this.Name = name;
        }

        public Tree()
        {
            Children = new List<Tree>();
        }
        
        public IEnumerator<Tree> GetEnumerator()
        {
            return Children.GetEnumerator();
        }
       public void Add(Tree tree)
        {        
          var a =Children as List<Tree>;  
          a.Add(tree);
        }
        
        public override string ToString()
        {
            return Name;
        }

    }
}
