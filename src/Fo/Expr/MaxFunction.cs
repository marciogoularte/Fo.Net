namespace Fonet.Fo.Expr
{
    internal class MaxFunction : FunctionBase
    {
        public override int NumArgs
        {
            get
            {
                return 2;
            }
        }

        public override Property Eval(Property[] args, PropertyInfo pInfo)
        {
            Numeric n1 = args[0].GetNumeric();
            Numeric n2 = args[1].GetNumeric();
            if (n1 == null || n2 == null)
            {
                throw new PropertyException("Non numeric operands to max function");
            }
            return new NumericProperty(n1.max(n2));
        }

    }
}