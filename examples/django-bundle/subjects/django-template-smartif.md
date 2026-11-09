# django/template/smartif

- Subject: django/template/smartif (id `f34128ef-5c36-4e3e-8679-b7eb1e3279c1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 22 of 39
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

16 more facts did not fit in the budget: [cff74de9] [22a0781d] [04e4f4df] [eee486165265df42-2] [694aed02] [7f01343b] [3cb23b6f] [503c1155] [77df08c0] [d2c56d9e] [ab995d16] [4f6b06f9] [d9c620c5] [e2968cbe] [1fc06594] [03c548c8]
