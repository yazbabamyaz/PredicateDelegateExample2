using PredicateApp2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Customer> customers= new List<Customer>
        {
            new Customer{Id=1,FirstName="Mustafa", LastName="Can", City="Istanbul"},
            new Customer{Id=2,FirstName="Ayşe", LastName="Yılmaz", City="Ankara"},
            new Customer{Id=3,FirstName="Salih", LastName="Kaya", City="Bursa"}
        };

        Predicate<Customer> predicCustomer=x=>x.Id==3;//tek paremetre  ve geriye bool dönen metot ya da lambda ifade bekler.
        Customer customer= customers.Find(predicCustomer);
        //Customer customer = customers.Find(x=>x.Id==1);

        Console.WriteLine(customer.FirstName+"-"+customer.City);
    }
}