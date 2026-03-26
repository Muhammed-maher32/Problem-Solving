#include <bits/stdc++.h>
using namespace std;
#define ll long long

bool dfs(ll node, ll target, vector<ll>& path) {
    path.push_back(node);

    if (node == target) return true;
    if (node > target) {
        path.pop_back();
        return false;
    }
    if (dfs(node * 2, target, path)) return true;
    if (dfs(node * 10 + 1, target, path)) return true;

    path.pop_back();
    return false;
}

int32_t main() {
    ios_base::sync_with_stdio(false); cin.tie(0); cout.tie(0);
    if (fopen("input.txt", "r")) {
        freopen("input.txt", "r", stdin);
        freopen("output.txt", "w", stdout);
    }
    int t = 1;
    //cin >> t;
    while (t--) {
        int a, b; cin >> a >> b;
        vector<ll>path;
        if (dfs(a, b, path)) {
            cout << "YES\n"; cout << path.size() << '\n';
            for (auto it : path)cout << it << ' ';
        }
        else cout << "NO\n";
    }
}
