# django/views/decorators/debug

- Subject: django/views/decorators/debug (id `eaa18bc1-8350-449f-8a2b-a05052d00f6f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 20 of 29
- Conflicts: 0
- Gaps: 0

## Facts

- @wraps(func) def sensitive_variables_wrapper(*func_args, **func_kwargs): if variables: sensitive_variables_wrapper.sensitive_variables = variables else: sensitive_variables_wrapper.sensitive_variables = "__ALL__" return func(*func_args, **func_kwargs) [aba582d1]
- @wraps(view) async def sensitive_post_parameters_wrapper(request, *args, **kwargs): if not isinstance(request, HttpRequest): raise TypeError( "sensitive_post_parameters didn't receive an HttpRequest " "object. If you are decorating a classmethod, make sure to use " "@method_decorator." ) if parameters: request.sensitive_post_parameters = parameters else: request.sensitive_post_parameters = "__ALL__" return await view(request, *args, **kwargs) [c7acb046]
- if variables: coroutine_functions_to_sensitive_variables[key] = variables else: coroutine_functions_to_sensitive_variables[key] = "__ALL__" [02361520]
- try: file_path = inspect.getfile(wrapped_func) except TypeError: # Raises for builtins or native functions. raise ValueError( f"{func.__name__} cannot safely be wrapped by " "@sensitive_variables, make it either non-async or defined in a " "Python file (not a builtin or from a native extension)." ) else: # A source file may not be available (e.g. in .pyc-only # builds), use the first line number instead. first_line_number = wrapped_func.__code__.co_firstlineno key = hash(f"{file_path}:{first_line_number}") [3e9bb3de]
- wrapped_func = func while getattr(wrapped_func, "__wrapped__", None) is not None: wrapped_func = wrapped_func.__wrapped__ [a7343948]
- @sensitive_post_parameters('password', 'credit_card') def my_view(request): pw = request.POST['password'] cc = request.POST['credit_card'] ... [20ccaaea]
- @sensitive_post_parameters() def my_view(request) ... """ if len(parameters) == 1 and callable(parameters[0]): raise TypeError( "sensitive_post_parameters() must be called to use it as a " "decorator, e.g., use @sensitive_post_parameters(), not " "@sensitive_post_parameters." ) [47e439a1]
- @sensitive_variables('user', 'password', 'credit_card') def my_function(user): password = user.pass_word credit_card = user.credit_card_number ... [e9165f40]
- @sensitive_variables() def my_function() ... """ if len(variables) == 1 and callable(variables[0]): raise TypeError( "sensitive_variables() must be called to use it as a decorator, " "e.g., use @sensitive_variables(), not @sensitive_variables." ) [e23be0d6]
- else: [6ad07797f4838346-24]
- else: [6ad07797f4838346-25]
- return sensitive_post_parameters_wrapper [08481411]
- return sensitive_variables_wrapper [46aa6fcb]
- * with specified parameters: [4182f604]
- * with specified variable names: [66b9784a]
- * without any specified parameters, in which case consider all variables are sensitive: [b96c630e]
- * without any specified variable names, in which case consider all variables are sensitive: [dabfc86e]
- Accept two forms: [2d30c255dc8877c5]
- Accept two forms: [2d30c255dc8877c5-2]
- def decorator(func): if iscoroutinefunction(func): sensitive_variables_wrapper = func [a5902558]

## Beyond the budget

8 more facts did not fit in the budget: [b5b049da] [021b5df2d691cbd2-8] [021b5df2d691cbd2-9] [c694de7d] [9abcb1a0] [121c2d9a] [65f270f6] [adc94a07]
