//Link: https://codeforces.com/contest/1201/problem/C

#include <bits/stdc++.h>
using namespace std;
#define ll long long
ll n, k, a[200005];
bool ok(ll mid) {
    ll s = 0;
    for (int i = n / 2; i < n; i++) {
        if (a[i] < mid) s += mid - a[i];
    }
    return s <= k;
}


void solve() {
    cin >> n >> k;
    for (int i = 0; i < n; i++) {
        cin >> a[i];
    }
    sort(a, a + n);

    ll l = a[n / 2], r = a[n / 2] + k, ans = a[n / 2];
    while (l <= r) {
        ll mid = (l + r) / 2;
        if (ok(mid)) {
            ans = mid, l = mid + 1;
        }
        else {
            r = mid - 1;
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
/*
hard work??!
*/
