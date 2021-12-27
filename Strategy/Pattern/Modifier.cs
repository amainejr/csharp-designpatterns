namespace Strategy.Pattern {
    using Strategy.Pattern.Modifiers;
    
    public class Modifier {
        private IModifierStrategy _strategy;

        public Modifier() {
            _strategy = new ShowLastFour();
        }

        public void SetStrategy(IModifierStrategy strategy) {
            _strategy= strategy;
        }

        public string Modify(string data) {
            return this._strategy.Modify(data);
        }
    }
}
