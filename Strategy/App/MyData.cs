namespace Strategy.App {
    using Strategy.Pattern;
    public struct MyData {
        public string content;
        public IModifierStrategy modifier;
    }
}