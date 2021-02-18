# Extract Method
* 挑選另外一塊程式碼來提煉
* 盡可能讓方法只回傳一個值
* 如果方法內的暫存變數過多，導致重構困難。  
建議將透過下列方法，把變數轉換為`查詢方法`或是`物件`，來整理這些變數。
    * Replace Temp with Query
    * Replace Method wit Method Object
    
    放任讓這些暫時變數，容易在後面寫出更長更難理解的程式碼。