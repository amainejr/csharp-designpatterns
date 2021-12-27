namespace Strategy.Pattern.Modifiers {
    public class ShowLastFour : IModifierStrategy {
        public string Modify(string data) {
            string redaction = new string('*', Math.Max(0, data.Length - 4));
            return redaction + data.Substring(Math.Max(0, data.Length - 4));
        }
    }
}
