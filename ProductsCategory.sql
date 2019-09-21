select Products.name, Category.name
from Products
    left join ProductsCategory on Products.id = ProductsCategory.products_id
    inner join Category on Category.id = ProductsCategory.category_id
order by Products.name