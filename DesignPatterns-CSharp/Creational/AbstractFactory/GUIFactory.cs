namespace DesignPatterns_CSharp.Creational.AbstractFactory
{
    // The abstract factory interface declares a set of methods that
    // return different abstract products. These products are called
    // a family and are related by a high-level theme or concept.
    // Products of one family are usually able to collaborate among
    // themselves. A family of products may have several variants,
    // but the products of one variant are incompatible with the
    // products of another variant.
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Concrete factories produce a family of products that belong
    // to a single variant. The factory guarantees that the
    // resulting products are compatible. Signatures of the concrete
    // factory's methods return an abstract product, while inside
    // the method a concrete product is instantiated.
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckBox();
        }
    }
    
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckBox();
        }
    }
}