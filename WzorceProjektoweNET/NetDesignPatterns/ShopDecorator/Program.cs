using ShopDecorator;
Decorator shopDecorator = new();
shopDecorator.PayByCach();
shopDecorator.PayByCard();

var shop = new Shop();
var shopDecoratorNoInheritence = new DekoratorBezDziedziczenia(shop);
shopDecoratorNoInheritence.PayByCach();
shopDecoratorNoInheritence.PayByCard();