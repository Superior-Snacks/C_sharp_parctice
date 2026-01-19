using static FieldValidatorAPI.CommonFieldValidatorFunctions;

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

    public class CommmonFieldValidatorFunctinos
    {
        private static RequierdValidDel _requierdValidDel = null;
        private static StringLengthValidDel _stringLengthValidDel = null;
        private static DateValidDel _dateValidDel = null;
        private static PatternMatchDel _patternMatchDel = null;
        private static CompareFieldsValidDel _compareFieldsValidDel = null;


    }
}
