#include <bits/stdc++.h>
using namespace std;

const int MAXN = 100005;

vector<int> G[MAXN];
vector<pair<int,int>> bridges;
int low[MAXN], vis[MAXN], T;

void dfs(int u, int p) {
    low[u] = vis[u] = ++T;
    for (int v : G[u]) {
        if (v == p) continue;
        if (!vis[v]) {
            dfs(v, u);
            low[u] = min(low[u], low[v]);
            if (low[v] > vis[u]) bridges.emplace_back(u, v);
        } else {
            low[u] = min(low[u], vis[v]);
        }
    }
}

vector<vector<int>> criticalConnections(int n, vector<vector<int>>& edges) {
    for (auto& e : edges) {
        G[e[0]].push_back(e[1]);
        G[e[1]].push_back(e[0]);
    }
    dfs(0, -1);
    vector<vector<int>> ans;
    for (auto& b : bridges) {
        ans.push_back({b.first, b.second});
    }
    return ans;
}

int main() {
    int n = 4;
    vector<vector<int>> connections = {{0,1},{1,2},{2,0},{1,3}};
    auto ans = criticalConnections(n, connections);
    for (auto& e : ans) {
        cout << e[0] << " " << e[1] << endl;
    }
    return 0;
}
