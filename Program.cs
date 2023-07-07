// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using SeDes;

var json = DoSerialization();
Console.WriteLine(json);
Console.WriteLine("================");
DoDeserialization(json);
Console.WriteLine("Usando método DoDeserializationUFO");
DoDeserializationUFO(json);

Console.WriteLine("Usando método SerializaProductos");
var jsonProductos = SerializaProductos();
Console.WriteLine(jsonProductos);

// Serialize a Rocket array to JSON string
static string DoSerialization() {
    Rocket[] rockets = {
        new Rocket{ ID = 0, Builder = "Roscosmos", Target = "Soyuz TM-13", Speed=7500},
        new Rocket{ ID = 1, Builder = "Roscosmos", Target = "Soyuz TM-14", Speed=7500},
        new Rocket{ ID = 2, Builder = "Roscosmos", Target = "Soyuz TM-15", Speed=7500},
        new Rocket{ ID = 3, Builder = "Roscosmos", Target = "Soyuz TM-16", Speed=7500},
        new Rocket{ ID = 3, Builder = "Roscosmos", Target = "Soyuz TM-17", Speed=7500}
    };
    var json = JsonConvert.SerializeObject(rockets);
    return json;
}

static string SerializaProductos() {
    ProductosUtil productosUtil = new ProductosUtil();
    List<Product> products = productosUtil.GenerarProductos();
    var json = JsonConvert.SerializeObject(products);
    return json;
}

// Deserialize a JSON string back to a Rocket array
static void DoDeserialization(string json) {
    var rockets = JsonConvert.DeserializeObject<Rocket[]>(json);
    if (rockets == null) {
        Console.WriteLine("El objeto rockets es nulo.");
        return;
    }
    foreach (var r in rockets) {
        System.Console.WriteLine($"ID:{r.ID} Builder:{r.Builder} Target:{r.Target} Speed:{r.Speed}");
    }
}

static void DoDeserializationUFO(string json) {
    var ufos = JsonConvert.DeserializeObject<UFO[]>(json);
    if (ufos == null)
    {
        Console.WriteLine("El objeto ufos es nulo.");
        return;
    }
    foreach (var ufo in ufos) {
        System.Console.WriteLine($"Target:{ufo.Target} Speed:{ufo.Speed}");
    }
}
