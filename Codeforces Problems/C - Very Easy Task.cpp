//Link: https://codeforces.com/edu/course/2/lesson/6/2/practice/contest/283932/problem/C
#include <bits/stdc++.h>
using namespace std;
#define ll long long
ll n, x, y;
bool ok(ll mid) {
    ll time = mid - min(x, y);
    if (time < 0) return false;
    return ((time / x) + (time / y)) >= n - 1;
}
void solve() {
    cin >> n >> x >> y;

    ll l = 0, r = 2 * 1e9, ans = 0;
    while (l <= r) {
        ll mid = (l + r) / 2;
        if (ok(mid)) {
            ans = mid, r = mid - 1;
        }
        else {
            l = mid + 1;
        }
    }
    cout << ans;
}

int main() {
    ios_base::sync_with_stdio(false); cin.tie(0); cout.tie(0);
#ifndef ONLINE_JUDGE
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
#endif
    int mizoo = 1; //testcases
    //cin >> mizoo;
    while (mizoo--) {
        solve();
    }
}
