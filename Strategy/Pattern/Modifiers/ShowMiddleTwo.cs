namespace Strategy.Pattern.Modifiers {
    public class ShowMiddleTwo : IModifierStrategy {
        public string Modify(string data) {
            if (data.Length > 1) {
                string redaction = "";
                if(data.Length % 2 == 0) {
                    redaction = new string('*', Math.Max(0, (data.Length / 2) - 1));
                    return redaction + data.Substring(Math.Max(0, (data.Length / 2) - 1), 2) + redaction;
                }
                redaction = new string('*', Math.Max(0, (data.Length / 2)));
                return redaction + data.Substring(Math.Max(0, data.Length / 2), 2) + redaction.Substring(1);
            }
            return data;
        }
    }
}
