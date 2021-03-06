# CW_DesignPatterns

## Как работи приложението

### Имплементация на DependencyInjection
- IWarehouse - интерфейсът, който се изполва за дефинирането на класа BaseWarehouse, също така той ще се inject-ва във всички други класове, които трябва да служат като Warehouse, но те няма да наследят BaseWarehouse
- BaseWarehouse - имплементация на IWarehouse
- FoodWarehouse - В началото на програмата се задава интерфейса IWarehouse като поле, а методите на FoodWarehouse ще работят с имплементацията на интерфейса, който ще бъде подаден в конструктора

### Имплементация на Adapter
- Shop - класът който ще служи като Adaptee в случая, докато интерфейса IWarehouse ще е в ролята на Target.
- ShopAdapter - Adapter класът, който носи отговорност да направи два несъвместими компоненти съвместими. Той също взима инстанция на Shop чрез конструктора.

### Имплементация на Iterator
- IteratorAggregate - връща итератор за имплементиращия обект 
- ObjectIterator - абстрактен клас, който дефинира абстрактните методи: 
  - Key() - връща ключа на текущия елемент
  - Current() - връща текущия елемент
  - MoveNext() - преминаване към следващия елемент ако има такъв
  - Reset() - връщане на итератора към първия елемент
- FoodIterator - имплементира методите от ObjectIterator, той взима инстанция на FoodWarehouse в конструктора, за да го използва като колекцията, с която ще работи 
- FoodWarehouse - наследява IteratorAggregate и override-ва GetEnumerator, за да върне нова инстанция на FoodIterator с текущата инстанция на FoodWarehouse

### Други
- Product - абстрактен клас, използван за дефиниране на продукти
- Food - наследява Product
