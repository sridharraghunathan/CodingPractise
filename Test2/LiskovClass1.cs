 

namespace Test2
{
    public   class BaseClass
    {
        public BaseClass(int id, string name, string description, string author, string title, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            Title = title;
            Price = price;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Author { get; }
        public string Title { get; }

        public int Price { get; }

        public virtual int  GetPrice()
        {
            return this.Price - this.GetDiscount(90);
        }

        public int GetDiscount(int discount)
        {
            return discount - 10;
        }
        

    }

    public class Child1 : BaseClass
    {
        public string SubAuthor { get; set; }
        public Child1(int id, string name, string description, string author, string title, int price,string subAuthor) 
            : base(id, name, description, author, title, price)
        {
            SubAuthor= subAuthor;
        }

        public int testing() {
            Console.WriteLine("outside testing method");
                    return 0;
        }


        public override int GetPrice()
        {
            testing();
           /*
            void testing() { Console.WriteLine("inside testing method"); }
           */
                 return this.Price - this.GetDiscount(60);
        }


        private new int GetDiscount(int discount)
        {
            return discount - 10;
        }
    }
}
