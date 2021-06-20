using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sercamcom
{
    public class SaleNode : IEquatable<SaleNode>
    {
        public string login;
        public string address;
        public string product;
        public int price;
        public bool typeOfPayment;

        public SaleNode(string login, string address, string name, int price, bool type)
        {
            this.login = login;
            this.address = address;
            this.product = name;
            this.price = price;
            this.typeOfPayment = type;
        }
        public SaleNode()
        {
            this.login = "";
            this.address = "";
            this.product = "";
            this.price = 0;
            this.typeOfPayment = false;
        }

        public int GetProductCode()
        {
            int code = 0;
            for (int i = 0; i < this.product.Length; i++)
            {
                code += (int)this.product[i];
            }
            return code;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ProductNode objAsPart = obj as ProductNode;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public bool Equals(SaleNode other)
        {
            if (other == null) return false;
            return (this.login.Equals(other.login) && this.product.Equals(other.product) && this.address.Equals(other.address) && this.price.Equals(other.price) && this.typeOfPayment.Equals(other.typeOfPayment));
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
