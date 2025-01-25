// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



ConcreteSubject concreteSubject = new ConcreteSubject();
concreteSubject.Attach(new ConcreteObserver("observer 1",concreteSubject));
concreteSubject.Attach(new ConcreteObserver("observer 2", concreteSubject));
concreteSubject.Attach(new ConcreteObserver("observer 3", concreteSubject));


var observer4 = new ConcreteObserver("observer 4", concreteSubject);
concreteSubject.Attach(observer4);


// Apply change on concrete subject


concreteSubject.SubjectState = "Apply change to state";

concreteSubject.Notify();
concreteSubject.Detach(observer4);


concreteSubject.SubjectState = "Apply again change to state";

concreteSubject.Notify();

Console.ReadKey();