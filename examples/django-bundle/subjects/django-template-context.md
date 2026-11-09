# django/template/context

- Subject: django/template/context (id `115348e2-4635-4fc5-ac68-fb97293f6537`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 18 of 49
- Conflicts: 0
- Gaps: 0

## Facts

- # empty dict for any new modifications # (so that context processors don't overwrite them) self.update({}) [5de249d6]
- # placeholder for context processors output self.update({}) [1719b65a]
- context.dicts.append(self) self.context = context [358ae4e6]
- self.dicts[self._processors_index] = updates [a390bcdf]
- self.template = template # Set context processors according to the template engine's settings. processors = template.engine.template_context_processors + self._processors updates = {} for processor in processors: context = processor(self.request) try: updates.update(context) except TypeError as e: raise TypeError( f"Context processor {processor.__qualname__} didn't return a " "dictionary." ) from e [61919b36]
- try: yield finally: self.template = None # Unset context processors. self.dicts[self._processors_index] = {} [57d0b17f]
- @contextmanager def bind_template(self, template): if self.template is not None: raise RuntimeError("Context is already bound to a template") [15392bec]
- @contextmanager def bind_template(self, template): if self.template is not None: raise RuntimeError("Context is already bound to a template") self.template = template try: yield finally: self.template = None [4e91e7e0]
- @contextmanager def push_state(self, template, isolated_context=True): initial = self.template self.template = template if isolated_context: self.push() try: yield finally: self.template = initial if isolated_context: self.pop() [f369d4ca]
- RenderContext simplifies the implementation of template Nodes by providing a safe place to store state between invocations of a node's `render` method. [9b2bea51]
- The RenderContext also provides scoping rules that are more sensible for 'template local' variables. The render context stack is pushed before each template is rendered, creating a fresh scope with nothing in it. Name resolution fails if a variable is not found at the top of the RequestContext stack. Thus, variables are local to a specific template and don't affect the rendering of other templates as they would if they were stored in the normal template context. """ [5091644f]
- def __contains__(self, key): return any(key in d for d in self.dicts) [7981328c]
- def __contains__(self, key): return key in self.dicts[-1] [fcd55c65]
- def __copy__(self): duplicate = BaseContext() duplicate.__class__ = self.__class__ duplicate.__dict__ = copy(self.__dict__) duplicate.dicts = self.dicts[:] return duplicate [cba8d7d3]
- def __copy__(self): duplicate = super().__copy__() duplicate.render_context = copy(self.render_context) return duplicate [4d95bbfa]
- def __delitem__(self, key): "Delete a variable from the current context" del self.dicts[-1][key] [ee3185df]
- def __enter__(self): return self [3ef33e95d940f83e-3]
- def __eq__(self, other): """ Compare two contexts by comparing their 'dicts' attributes. """ if not isinstance(other, BaseContext): return NotImplemented # flatten dictionaries because they can be put in a different order. return self.flatten() == other.flatten() [5ff10a8b]

## Beyond the budget

31 more facts did not fit in the budget: [8afde90a] [d5d27fad] [4fcff80d] [f1f06396] [760f7a9d] [e8f93543] [a501245a] [f099985c] [596b1dd1] [8e3f6da0] [b8f57e12] [cda4b6ec] [f0981052] [8ee872bd] [767c29f0] [b397344c] [cfdb22b8] [fe4b5ac6] [1acbbe26] [a65aa2b7] [7655780f0d17b825-52] [b607e6cb] [7cdeb32f] [44e4746b] [f5e9bbed] [481422dd] [72f723eb] [3ac22c75] [4cd4b425] [d7e5ac84] [d49103cf]
