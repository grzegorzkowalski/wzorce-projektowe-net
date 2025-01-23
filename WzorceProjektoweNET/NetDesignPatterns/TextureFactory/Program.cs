TextureFactory factory = new TextureFactory();

// Współdzielenie tekstur
Texture grassTexture = factory.GetTexture("grass.png");
grassTexture.Render(0, 0);

Texture grassTexture2 = factory.GetTexture("grass.png");
grassTexture2.Render(10, 0);

Texture stoneTexture = factory.GetTexture("stone.png");
stoneTexture.Render(5, 5);

// Zauważ, że tekstura "grass.png" została wczytana tylko raz