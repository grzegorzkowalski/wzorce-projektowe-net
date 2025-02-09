using ShopDecorator;
Decorator shopDecorator = new();
shopDecorator.PayByCash();
shopDecorator.PayByCard();

var shop = new Shop();
var shopDecoratorNoInheritence = new DekoratorBezDziedziczenia(shop);
shopDecoratorNoInheritence.PayByCash();
shopDecoratorNoInheritence.PayByCard();