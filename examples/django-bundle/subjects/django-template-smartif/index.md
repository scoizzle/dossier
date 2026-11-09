# django/template/smartif

- Subject: django/template/smartif (id `98025caa-5f67-400f-bbc4-b33f0737e281`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1707 tokens
- Facts shown: 38 of 39
- Conflicts: 0
- Gaps: 0

## Highlights

- def eval(self, context): try: return func(context, self.first) except Exception: return False [037d51cf]
- def eval(self, context): try: return func(context, self.first, self.second) except Exception: # Templates shouldn't throw exceptions when rendering. We are # most likely to get exceptions for things like: # {% if foo in bar %} # where 'bar' does not support 'in', so default to False. return False [cefb2b19]
- def led(self, left, parser): self.first = left self.second = parser.expression(bp) return self [7c461e60]
- def nud(self, parser): self.first = parser.expression(bp) self.second = None return self [a94a868c]
- self.tokens = mapped_tokens self.pos = 0 self.current_token = self.next_token() [76beb34a]
- # IfParser uses Literal in create_var, but TemplateIfParser overrides # create_var so that a proper implementation that actually resolves # variables, filters etc. is used. id = "literal" lbp = 0 [e72da232]
- class Operator(TokenBase): lbp = bp [96c4466c957b9f82]
- def __init__(self, tokens): # Turn 'is','not' and 'not','in' into single tokens. num_tokens = len(tokens) mapped_tokens = [] i = 0 while i < num_tokens: token = tokens[i] if token == "is" and i + 1 < num_tokens and tokens[i + 1] == "not": token = "is not" i += 1 # skip 'not' elif token == "not" and i + 1 < num_tokens and tokens[i + 1] == "in": token = "not in" i += 1 # skip 'in' mapped_tokens.append(self.translate_token(token)) i += 1 [67c12b3d]
- def __init__(self, value): self.value = value [865ca027]
- def __repr__(self): out = [str(x) for x in [self.id, self.first, self.second] if x is not None] return "(" + " ".join(out) + ")" [050ca164]
- def __repr__(self): return "(%s %r)" % (self.id, self.value) [5d73cc78]
- def create_var(self, value): return Literal(value) [25a8c168]
- def display(self): """ Return what to display in error messages for this node """ return self.id [054b8b76]
- def display(self): return repr(self.value) [bb9d8596]
- def eval(self, context): return self.value [f1e87b6a]
- def expression(self, rbp=0): t = self.current_token self.current_token = self.next_token() left = t.nud(self) while rbp < self.current_token.lbp: t = self.current_token self.current_token = self.next_token() left = t.led(left, self) return left [e2c2616f]
- def led(self, left, parser): # Left denotation - called in infix context raise parser.error_class( "Not expecting '%s' as infix operator in if tag." % self.id ) [95daeb96]
- def next_token(self): if self.pos >= len(self.tokens): return EndToken else: retval = self.tokens[self.pos] self.pos += 1 return retval [2a474a68]
- def nud(self, parser): # Null denotation - called in prefix context raise parser.error_class( "Not expecting '%s' in this position in if tag." % self.id ) [45fefc41]
- def nud(self, parser): raise parser.error_class("Unexpected end of expression in if tag.") [838e89de]
- def nud(self, parser): return self [281a83d3]
- return Operator [eee486165265df42]

## All facts

- [cff74de9] def parse(self): retval = self.expression() # Check that we have exhausted all the tokens if self.current_token is not EndToken: raise self.error_class( "Unused '%s' at end of if expression." % self.current_token.display() ) return retval
- [22a0781d] def translate_token(self, token): try: op = OPERATORS[token] except (KeyError, TypeError): return self.create_var(token) else: return op()
- [04e4f4df] id = None # node/token type name value = None # used by literals first = second = None # used by tree nodes
- [eee486165265df42-2] return Operator
- [694aed02] """ Parser and utilities for the smart 'if' tag """
- [7f01343b] # Assign 'id' to each: def _init_operators(): for key, op in OPERATORS.items(): op.id = key
- [3cb23b6f] # Operator precedence follows Python. # We defer variable evaluation to the lambda to ensure that terms are # lazily evaluated using Python's boolean parsing logic. OPERATORS = { "or": infix(6, lambda context, x, y: x.eval(context) or y.eval(context)), "and": infix(7, lambda context, x, y: x.eval(context) and y.eval(context)), "not": prefix(8, lambda context, x: not x.eval(context)), "in": infix(9, lambda context, x, y: x.eval(context) in y.eval(context)), "not in": infix(9, lambda context, x, y: x.eval(context) not in y.eval(context)), "is": infix(10, lambda context, x, y: x.eval(context) is y.eval(context)), "is not": infix(10, lambda context, x, y: x.eval(context) is not y.eval(context)), "==": infix(10, lambda context, x, y: x.eval(context) == y.eval(context)), "!=": infix(10, lambda context, x, y: x.eval(context) != y.eval(context)), ">": infix(10, lambda context, x, y: x.eval(context) > y.eval(context)), ">=": infix(10, lambda context, x, y: x.eval(context) >= y.eval(context)), "<": infix(10, lambda context, x, y: x.eval(context) < y.eval(context)), "<=": infix(10, lambda context, x, y: x.eval(context) <= y.eval(context)), }
- [503c1155] # Using a simple top down parser, as described here: # https://11l-lang.org/archive/simple-top-down-parsing/ # 'led' = left denotation # 'nud' = null denotation # 'bp' = binding power (left = lbp, right = rbp)
- [77df08c0] EndToken = EndToken()
- [d2c56d9e] _init_operators()
- [ab995d16] class EndToken(TokenBase): lbp = 0
- [4f6b06f9] class IfParser: error_class = ValueError
- [d9c620c5] class Literal(TokenBase): """ A basic self-resolvable object similar to a Django template variable. """
- [e2968cbe] class TokenBase: """ Base class for operators and literals, mainly for debugging and for throwing syntax errors. """
- [1fc06594] def infix(bp, func): """ Create an infix operator, given a binding power and a function that evaluates the node. """
- [03c548c8] def prefix(bp, func): """ Create a prefix operator, given a binding power and a function that evaluates the node. """
