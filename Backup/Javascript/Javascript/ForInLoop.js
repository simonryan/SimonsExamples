var a = ["one", "two", "three"];

for (var o in a) {
    log(a[o]); // o represents the index NOT the object itself
}
