# django/db/migrations/graph

- Subject: django/db/migrations/graph (id `95fe4d4a-7add-47e0-8e5b-f31489ed036a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 21 of 40
- Conflicts: 0
- Gaps: 0

## Facts

- A node should be a tuple: (app_path, migration_name). The tree special-cases things within an app - namely, root nodes and leaf nodes ignore dependencies to other apps. """ [09ec5132]
- After the migration graph is processed, all dummy nodes should be removed. If there are any left, a nonexistent dependency error is raised. """ [cb924cc3]
- Each migration is a node, and each dependency is an edge. There are no implicit dependencies between numbered migrations - the numbering is merely a convention to aid file listing. Every new numbered migration has a declared dependency to the previous number, meaning that VCS branch merges can be detected and resolved. [96e2b897]
- Migrations files can be marked as replacing another set of migrations - this is to support the "squash" feature. The graph handler isn't responsible for these; instead, the code to load them in here should examine the migration files and if the replaced migrations are all either unapplied or not present, it should ignore the replaced ones, load in just the replacing migration, and repoint any dependencies that pointed to the replaced migrations to point to the replacing one. [7de67e9e]
- def __contains__(self, node): return node in self.nodes [529bd35b]
- def __eq__(self, other): return self.key == other [f19afdf2]
- def __getitem__(self, item): return self.key[item] [a75cdd09]
- def __hash__(self): return hash(self.key) [378d0397]
- def __init__(self): self.node_map = {} self.nodes = {} [20e02735]
- def __init__(self, key): self.key = key self.children = set() self.parents = set() [3e2a86bc]
- def __init__(self, key, origin, error_message): super().__init__(key) self.origin = origin self.error_message = error_message [14ac4168]
- def __lt__(self, other): return self.key < other [dbf49926]
- def __repr__(self): nodes, edges = self._nodes_and_edges() return "<%s: nodes=%s, edges=%s>" % (self.__class__.__name__, nodes, edges) [ae19ff2c]
- def __repr__(self): return "<%s: (%r, %r)>" % (self.__class__.__name__, self.key[0], self.key[1]) [37f65d67]
- def __str__(self): return "Graph: %s nodes, %s edges" % self._nodes_and_edges() [2318ea6a]
- def __str__(self): return str(self.key) [39cdc924]
- def _generate_plan(self, nodes, at_end): plan = OrderedSet() for node in nodes: for migration in self.forwards_plan(node): if migration not in plan and (at_end or migration not in nodes): plan.add(migration) return list(plan) [02635955]
- def _nodes_and_edges(self): return len(self.nodes), sum( len(node.parents) for node in self.node_map.values() ) [b99f89da]
- def add_child(self, child): self.children.add(child) [5db92913]
- def add_dummy_node(self, key, origin, error_message): node = DummyNode(key, origin, error_message) self.node_map[key] = node self.nodes[key] = None [7d284c89]
- def add_node(self, key, migration): assert key not in self.node_map node = Node(key) self.node_map[key] = node self.nodes[key] = migration [62849d23]

## Beyond the budget

19 more facts did not fit in the budget: [62c969b0] [28823373] [4535eb54] [f88e4568] [80952e61] [cc70e191] [3615ff35] [9f81b8b3] [90c0aafd] [54b7fd69] [72e2b55a] [9844feb9] [4e7d2a3d] [8273f57f] [60c3c5ed] [41099d9e] [feb70751] [604dae4b] [363dc81b4a0151df-2]
