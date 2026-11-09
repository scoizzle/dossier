# django/utils/tree

- Subject: django/utils/tree (id `184d44e5-7401-410b-8474-778b5a1c9e87`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 15 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- Return a node which can be used in place of data regardless if the node other got squashed or not. """ if self.connector != conn_type: obj = self.copy() self.connector = conn_type self.children = [obj, data] return data elif ( isinstance(data, Node) and not data.negated and (data.connector == conn_type or len(data) == 1) ): # We can squash the other node's children directly into this node. # We are just doing (AB)(CD) == (ABCD) here, with the addition that # if the length of the other node is 1 the connector doesn't # matter. However, for the len(self) == 1 case we don't want to do # the squashing, as it would alter self.connector. self.children.extend(data.children) return self else: # We could use perhaps additional logic here to see if some # children could be used for pushdown here. self.children.append(data) return data [d83389a2]
- This tree (self) will never be pushed to a child node of the combined tree, nor will the connector or negated properties change. [9a56cf25]
- # Standard connector type. Clients usually won't use this at all and # subclasses will usually override the value. default = "DEFAULT" [4c6421bd]
- @classmethod def create(cls, children=None, connector=None, negated=False): """ Create a new instance using Node() instead of __init__() as some subclasses, e.g. django.db.models.query_utils.Q, may implement a custom __init__() with a signature that conflicts with the one defined in Node.__init__(). """ obj = Node(children, connector or cls.default, negated) obj.__class__ = cls return obj [75a67386]
- copy = __copy__ [9d965cb1]
- def __bool__(self): """Return whether or not this node has children.""" return bool(self.children) [84fbaccb]
- def __contains__(self, other): """Return True if 'other' is a direct child of this instance.""" return other in self.children [49d5857c]
- def __copy__(self): obj = self.create(connector=self.connector, negated=self.negated) obj.children = self.children # Don't [:] as .__init__() via .create() does. return obj [8fa46761]
- def __deepcopy__(self, memodict): obj = self.create(connector=self.connector, negated=self.negated) obj.children = copy.deepcopy(self.children, memodict) return obj [09f9b7f1]
- def __eq__(self, other): return ( self.__class__ == other.__class__ and self.connector == other.connector and self.negated == other.negated and self.children == other.children ) [5ee1722d]
- def __hash__(self): return hash( ( self.__class__, self.connector, self.negated, *make_hashable(self.children), ) ) [e6dd9cd5]
- def __init__(self, children=None, connector=None, negated=False): """Construct a new Node. If no connector is given, use the default.""" self.children = children[:] if children else [] self.connector = connector or self.default self.negated = negated [d41972cc]
- def __len__(self): """Return the number of children this node has.""" return len(self.children) [01505a91]
- def __repr__(self): return "<%s: %s>" % (self.__class__.__name__, self) [786242c26f533382-7]
- def __str__(self): template = "(NOT (%s: %s))" if self.negated else "(%s: %s)" return template % (self.connector, ", ".join(str(c) for c in self.children)) [3c6c33a2]

## Beyond the budget

6 more facts did not fit in the budget: [e04c2255] [82376ed8] [0f39b6d1] [3971f629] [7c27c9fd099764a6-2] [f73b37390b76138d-2]
