using System;
using Strategy.Pattern;
using Strategy.Pattern.Modifiers;
using Strategy.App;

MyData[] myData = new MyData[] {
    new MyData { content = "123-456-7890", modifier = new ShowLastFour() },
    new MyData { content = "123456", modifier = new ShowMiddleTwo() }
};

var modifier = new Modifier();

foreach(var record in myData) {
    modifier.SetStrategy(record.modifier);
    Console.WriteLine(modifier.Modify(record.content));
}
