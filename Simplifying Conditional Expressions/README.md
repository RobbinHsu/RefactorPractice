## 引入Null Object(Introduce NullObject)
---
對於有很多特定行為(本例中要判斷很多次 Customer 是不是 null)要判斷的物件，建立一個子類別(NullCustomer)，並在其中集中管理這些行為。
* 針對有許多null狀態要處理的 Customer 類別，建立一個 NullCustomer 子類別。
* Customer 類別會新增一個靜態方法用來回傳 NullCustomer (Factory Method)，不讓外面直接接觸到 NullCustomer。
    ```csharp
    public class Customer
    {
        public static Customer NewNull()
        {
            return new NullCustomer();
        }
    }
    ```
* 在 NullCustomer 中，覆寫原本 Customer 的方法，把原來判斷為 null
 時的行為集中在此。
    ```csharp
    public class NullCustomer
    {
        public override string GetName()
        {
            return "occupant";
        }
    }
    ```
* 呼叫 Customer 類別的地方，判斷是否為 null。
    ```csharp
    public class Site
    {
        private readonly Customer _customer;

        public Customer Customer => _customer ?? Customer.NewNull();

        public Site(Customer customer)
        {
            _customer = customer;
        }
    }
    ```

