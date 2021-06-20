using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sercamcom
{
    public class ProductNode : IEquatable<ProductNode>
    {
        public string login;
        public string product;
        public ProductNode()
        {
            login = "";
            product = "";
        }
        public ProductNode(string login, string product)
        {
            this.login = login;
            this.product = product;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ProductNode objAsPart = obj as ProductNode;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public bool Equals(ProductNode other)
        {
            if (other == null) return false;
            return (this.login.Equals(other.login) && this.product.Equals(other.product));
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
