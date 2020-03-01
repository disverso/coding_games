import 'dart:io';
import "dart:collection";

/// Graffiti on the fence - Solution
/// Link: https://www.codingame.com/training/easy/graffiti-on-the-fence

void main() {
    List inputs;
    int L = int.parse(stdin.readLineSync());
    int N = int.parse(stdin.readLineSync());
    SplayTreeMap<int, int> paintedParts = SplayTreeMap<int, int>();
    bool allPainted = true;
    for (int i = 0; i < N; i++) {
        inputs = stdin.readLineSync().split(' ');
        int st = int.parse(inputs[0]);
        int ed = int.parse(inputs[1]);
        paintedParts[st] = ed;
    }
    
    int current = 0;
    
    for (int key in paintedParts.keys) {
        if (current < key) {
            print('$current $key');
            current = paintedParts[key];
            allPainted = false;
        } else if (current < paintedParts[key]) {
            current = paintedParts[key];
        }
    }

    if (current < L) {
        print('$current $L');
        allPainted = false;
    }
    
    if (allPainted) {
        print("All painted");
    }
}
