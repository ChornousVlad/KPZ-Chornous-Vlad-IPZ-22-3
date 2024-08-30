using Task3;

IProcessingModule vectorRenderer = new DirectionProcessingModule();
IProcessingModule rasterRenderer = new PixelProcessingModule();

Shape vectorCircle = new Circle(vectorRenderer);
Shape rasterCircle = new Circle(rasterRenderer);

Shape vectorSquare = new Square(vectorRenderer);
Shape rasterSquare = new Square(rasterRenderer);

Shape vectorTriangle = new Triangle(vectorRenderer);
Shape rasterTriangle = new Triangle(rasterRenderer);

vectorCircle.Draw();
rasterCircle.Draw();

vectorSquare.Draw();
rasterSquare.Draw();

vectorTriangle.Draw();
rasterTriangle.Draw();