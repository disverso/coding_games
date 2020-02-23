import 'dart:io';
import 'dart:math';

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
void main() {
    List inputs;
    int n = int.parse(stdin.readLineSync()); // the number of temperatures to analyse
    
    int temp = 5526; // max temp
    
    if (n == 0) {
        temp = 0;
    }
    
    inputs = stdin.readLineSync().split(' ');
    for (int i = 0; i < n; i++) {
        
        int t = int.parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
        
        if (temp.abs() == t.abs()) {
            temp = temp > t ? temp : t;
        } else {
            temp = temp.abs() < t.abs() ? temp : t;
        }
    }

    
    print(temp);
}
