# docs/howto/error-reporting

- Subject: docs/howto/error-reporting (id `63f6be68-b753-4855-8ab8-d288708e97cc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 22 of 102
- Conflicts: 0
- Gaps: 0

## Facts

- @sensitive_variables("user", "pw", "cc") @some_decorator @another_decorator def process_info(user): ... [d2ea5bf8]
- class CustomExceptionReporter(ExceptionReporter): def get_traceback_data(self): data = super().get_traceback_data() # ... remove/add something here ... return data [8ac03c23]
- from django.views.debug import ExceptionReporter [eed2498c]
- import re [90f4387cea1dbdff-3]
- re.compile(r"API|AUTH|TOKEN|KEY|SECRET|PASS|SIGNATURE|HTTP_COOKIE", flags=re.IGNORECASE) [82381211]
- @sensitive_post_parameters("pass_word", "credit_card_number") def record_user_profile(request): UserProfile.create( user=request.user, password=request.POST["pass_word"], credit_card=request.POST["credit_card_number"], name=request.POST["name"], ) ... [817b6b58]
- @sensitive_post_parameters() def my_view(request): ... [756e351d]
- @sensitive_variables("user", "pw", "cc") def process_info(user): pw = user.pass_word cc = user.credit_card_number name = user.name ... [1a6f2287]
- @sensitive_variables() def my_function(): ... [38aa577d]
- A compiled regular expression object used to match settings and ``request.META`` values considered as sensitive. By default equivalent to:: [51b21e89]
- If the variable you want to hide is also a function argument (e.g. '``user``’ in the following example), and if the decorated function has multiple decorators, then make sure to place ``@sensitive_variables`` at the top of the decorator chain. This way it will also hide the function argument as it gets passed through the other decorators:: [adffd60b]
- Property that returns a :class:`pathlib.Path` representing the absolute filesystem path to a template for rendering the HTML representation of the exception. Defaults to the Django provided template. [c1a808ab]
- Return HTML version of exception report. [657d938d]
- Return a dictionary containing traceback information. [1012f4f2]
- Return plain text version of exception report. [9aa3321e]
- Returns ``True`` to activate the filtering in :meth:`get_post_parameters` and :meth:`get_traceback_frame_variables`. By default the filter is active if :setting:`DEBUG` is ``False``. Note that sensitive ``request.META`` values are always filtered along with sensitive setting values, as described in the :setting:`DEBUG` documentation. [853e4267]
- Returns the filtered dictionary of POST parameters. Sensitive values are replaced with :attr:`cleansed_substitute`. [3c737d9b]
- Returns the filtered dictionary of local variables for the given traceback frame. Sensitive values are replaced with :attr:`cleansed_substitute`. [e0e896e6]
- The string value to replace sensitive value with. By default it replaces the values of sensitive variables with stars (``**********``). [6610a2b0]
- This is the main extension point for customizing exception reports, for example:: [18fe418f]
- Used for HTML version of debug 500 HTTP error page. [12820590]
- from django.views.decorators.debug import sensitive_variables [54f47e7c]

## Beyond the budget

79 more facts did not fit in the budget: [99f89ea8] [77e7515a] [53920bf8] [0aac7a90] [006a4503] [90900aa3] [1b042c19] [686ccf66] [f2f9e74c] [bb701313] [9f5d9349] [78366855] [529cb51b] [bd0e8028] [859697be] [e973f76f] [ab437fee] [21f0b744] [af85fd2c] [1f24cfa9] [c728cd4d] [88d57552] [6bbcd0a8] [e375a126] [e1a7aa65] [9c64f938] [503f9891] [c342df21] [86e2628e] [c7a49aec] [2aa0760d] [90f4387cea1dbdff-4] [90f4387cea1dbdff-5] [179852e2] [39b16fe2] [b806aa44] [0b9e6188] [5a41c135] [6c69a34a] [5d28bd98] [9b150535] [9aa35b76] [21541574] [7c235117] [3551131d] [848e58cc] [942ae6c11625c81c-6] [942ae6c11625c81c-7] [6b4a5e54e001d097-2] [6b4a5e54e001d097-3] [6b4a5e54e001d097-4] [c54b54cb0805732a-6] [e3d98449] [733e3092] [dc92633c] [55234a3f] [c039a8f8] [ebf1370d] [76ca8884] [76ff035d] [ea8bcb02] [09590a8c] [e31f2d5d] [1a640efb] [9b3f8039] [8385cdc2] [2718edd2] [6c1a9856] [9db74f00] [067e76a9] [71f38086] [d8a25e21] [ce671b5e] [8b2eba01] [b8f79bea] [90bb03d7] [78ed29bd] [b62aad5e] [c51e1404]
