namespace Strategy.Pattern.Modifiers {
    public class ShowAll : IModifierStrategy {
        public string Modify(string data) {
            return data;
        }
    }
}
