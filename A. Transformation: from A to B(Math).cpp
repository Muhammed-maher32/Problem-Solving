#include <bits/stdc++.h>
using namespace std;
#define ll long long

int32_t main() {
    ios_base::sync_with_stdio(false); cin.tie(0); cout.tie(0);
    if (fopen("input.txt", "r")) {
        freopen("input.txt", "r", stdin);
        freopen("output.txt", "w", stdout);
    }
    int t = 1;
    //cin >> t;
    while (t--) {
        ll a, b; cin >> a >> b;
        vector<ll> path;
        path.push_back(b);
        while (b > a) {
            if (b % 2 == 0) b /= 2;
            else if (b % 10 == 1) b /= 10;
            else break;

            path.push_back(b);
        }
        if (b != a) {
            cout << "NO" << '\n';
            return 0;
        }
        cout << "YES" << '\n';
        reverse(path.begin(), path.end());
        cout << path.size() << '\n';
        for (int i = 0; i < path.size(); i++) {
            cout << path[i] << ' ';
        }
    }

}
