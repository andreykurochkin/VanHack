using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.CountingValleys {
    public class Route {
        private int Steps { get; }
        private string Path { get; }
        private char Up => 'U';
        private char Down => 'D';
        public Route(int steps, string path) {
            Steps = steps;
            Path = path;
        }
        public int CountingValleys(int[] path) {
            int amountOf0 = 0;
            for (int i = 0; i < path.Length - 1; i++) {
                if ((path[i]==0) && (path[i+1]==-1)) {
                    amountOf0++;
                }
            }
            return amountOf0;
        }
        public int[] Parse() {
            var result = new int[Steps + 2];
            result[0] = 0;
            result[Steps+1] = 0;
            for (int i = 0; i < Path.Length - 1; i++) {
                if (Path[i] == Up) {
                    result[i+1] = result[i] + 1;
                }
                if (Path[i] == Down) {
                    result[i+1] = result[i] - 1;
                }
            }
            return result;
        }
    }
}
