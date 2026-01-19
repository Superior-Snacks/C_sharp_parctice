namespace FieldValidatorAPI
{
    public class CommonFieldValidatorFunctions
    {
        public delegate bool RequierdValidDel(string filedVal);
        public delegate bool StringLengthValidDel(string fieldVal, int min, int max);
        public delegate bool DateValidDel(string fieldVal, out DateTime ValidDateTime);
        public delegate bool PatternMatchDel(string fieldVal, string pattern);
        public delegate bool CompareFieldsValidDel(string fieldVal, string fieldValCompare);
    }
}
