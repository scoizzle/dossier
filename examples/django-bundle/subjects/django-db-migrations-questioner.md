# django/db/migrations/questioner

- Subject: django/db/migrations/questioner (id `ef8a814f-03f8-408c-a6fd-33640f988174`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 9 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- The ``default`` argument allows providing a custom default value (as a string) which will be shown to the user and used as the return value if the user doesn't provide any other input. """ self.prompt_output.write("Please enter the default value as valid Python.") if default: self.prompt_output.write( f"Accept the default '{default}' by pressing 'Enter' or " f"provide another value." ) self.prompt_output.write( "The datetime and django.utils.timezone modules are available, so " "it is possible to provide e.g. timezone.now as a value." ) self.prompt_output.write("Type 'exit' to exit this prompt") while True: if default: prompt = "[default: {}] >>> ".format(default) else: prompt = ">>> " self.prompt_output.write(prompt, ending="") try: code = input() except KeyboardInterrupt: self.prompt_output.write("\nCancelled.") sys.exit(1) if not code and default: code = default if not code: self.prompt_output.write( "Please enter some code, or 'exit' (without quotes) to exit." ) elif code == "exit": sys.exit(1) else: try: return eval(code, {}, {"datetime": datetime, "timezone": timezone}) except Exception as e: self.prompt_output.write(f"{e.__class__.__name__}: {e}") [665182dd]
- def __init__(self, defaults=None, specified_apps=None, dry_run=None): self.defaults = defaults or {} self.specified_apps = specified_apps or set() self.dry_run = dry_run [27bee7ef]
- def _ask_default(self, default=""): """ Prompt for a default value. [78410db0]
- def _boolean_input(self, question, default=None): self.prompt_output.write(f"{question} ", ending="") result = input() if not result and default is not None: return default while not result or result[0].lower() not in "yn": self.prompt_output.write("Please answer yes or no: ", ending="") result = input() return result[0].lower() == "y" [615fd9e8]
- def _choice_input(self, question, choices): self.prompt_output.write(f"{question}") for i, choice in enumerate(choices): self.prompt_output.write(" %s) %s" % (i + 1, choice)) self.prompt_output.write("Select an option: ", ending="") while True: try: result = input() value = int(result) except ValueError: pass except KeyboardInterrupt: self.prompt_output.write("\nCancelled.") sys.exit(1) else: if 0 < value <= len(choices): return value self.prompt_output.write("Please select a valid option: ", ending="") [b034c9d9]
- def ask_auto_now_add_addition(self, field_name, model_name): """Adding an auto_now_add field to a model.""" # None means quit return None [adb8fba9]
- def ask_auto_now_add_addition(self, field_name, model_name): """Adding an auto_now_add field to a model.""" if not self.dry_run: choice = self._choice_input( f"It is impossible to add the field '{field_name}' with " f"'auto_now_add=True' to {model_name} without providing a " f"default. This is because the database needs something to " f"populate existing rows.\n", [ "Provide a one-off default now which will be set on all " "existing rows", "Quit and manually define a default value in models.py.", ], ) if choice == 2: sys.exit(3) else: return self._ask_default(default="timezone.now") return None [4fd19615]
- def ask_merge(self, app_label): """Should these migrations really be merged?""" return self.defaults.get("ask_merge", False) [173cee99]
- from .loader import MigrationLoader [fb588b6d]

## Beyond the budget

21 more facts did not fit in the budget: [2361713a] [fd99a42d] [621672a4] [b3aeb4bb] [3146e07c] [e0f565cd] [1383093d] [906af2fa] [a69f74cf] [1d11f470] [3b23483d] [0ba1745a] [d1aaab9b] [d692508c] [d68108b4] [663e9de0] [3311bf2a] [7cfc2afc] [562312cd] [1f191e56] [505da254]
