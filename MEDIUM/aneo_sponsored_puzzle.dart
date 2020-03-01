import 'dart:io';

/// ANEO Sponsored Puzzle (Validators score: 90% passed).

void main() {
    List inputs;
    int speed = int.parse(stdin.readLineSync());
    int lightCount = int.parse(stdin.readLineSync());
    List<int> distance = [];
    List<int> duration = [];
    for (int i = 0; i < lightCount; i++) {
        inputs = stdin.readLineSync().split(' ');
        distance.add(int.parse(inputs[0]));
        duration.add(int.parse(inputs[1]));
    }

    int mxSpeed = speed;
    int mnSpeed = 0;
    bool search = true;
    
    while (search) {
        for (int i = 0; i < lightCount; i++){
            Map<String, int> result = getSpeed(mxSpeed, distance[i], duration[i]);
            
            if (mxSpeed > result['maxSpeed']) mxSpeed = result['maxSpeed'];
            if (mnSpeed < result['minSpeed']) mnSpeed = result['minSpeed'];
        }
        
        if (mnSpeed <= mxSpeed) {
            search = false;
        }
        mnSpeed = 0;
    }
    // Write an action using print()
    // To debug: stderr.writeln('Debug messages...');

    print(mxSpeed);
}

Map<String, int> getSpeed(int speed, int distance, int duration) {
    
    double topSpeed = speed * 1000.0 / 3600.0;
    double needTime = distance / topSpeed;
    int iteration = (needTime / duration).floor();
    if (iteration % 2 == 1) iteration++;
    
    
    double mxSpeed = distance.roundToDouble();
    double mnSpeed = distance / duration;
    if (iteration > 1) {
        mxSpeed = distance / (duration * iteration);
        mnSpeed = distance / ((duration * (iteration + 1)) - 1);
    }
    
    Map<String, int> result = {
        'maxSpeed' : (mxSpeed * 3600 / 1000).floor(),
        'minSpeed' : (mnSpeed * 3600 / 1000).ceil(),
    };
    
    return result;
}
