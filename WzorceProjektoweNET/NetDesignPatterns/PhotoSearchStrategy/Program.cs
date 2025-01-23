using PhotoSearchStrategy;

var pexel = new Pexels();
var pixabay = new Pixabay();
var redaction = new Redaction();
redaction.SetStrategy(pexel);
redaction.FindPhotos("Nature");
redaction.SetStrategy(pixabay);
redaction.FindPhotos("Nature");