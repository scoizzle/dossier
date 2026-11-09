# django/core/management/commands/test

- Subject: django/core/management/commands/test (id `e43dcd24-f82a-4345-b80a-a0380eb0ebeb`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 583 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- if hasattr(test_runner_class, "add_arguments"): test_runner_class.add_arguments(parser) [d6a8b763]
- test_runner_class = get_runner(settings, self.test_runner) [e1da89df]
- time_keeper = TimeKeeper() if options.get("timing", False) else NullTimeKeeper() parallel = options.get("parallel") if parallel == "auto": options["parallel"] = get_max_test_processes() test_runner = TestRunner(**options) with time_keeper.timed("Total run"): failures = test_runner.run_tests(test_labels) time_keeper.print_results() if failures: sys.exit(1) [fdc0514d]
- # DiscoverRunner runs the checks after databases are set up. requires_system_checks = [] test_runner = None [a6b576ad]
- def add_arguments(self, parser): parser.add_argument( "args", metavar="test_label", nargs="*", help=( "Module paths to test; can be modulename, modulename.TestCase or " "modulename.TestCase.test_method" ), ) parser.add_argument( "--noinput", "--no-input", action="store_false", dest="interactive", help="Tells Django to NOT prompt the user for input of any kind.", ) parser.add_argument( "--testrunner", help="Tells Django to use specified test runner class instead of " "the one specified by the TEST_RUNNER setting.", ) [30137e4e]
- def handle(self, *test_labels, **options): TestRunner = get_runner(settings, options["testrunner"]) [be33f2a1]
- def run_from_argv(self, argv): """ Pre-parse the command line to extract the value of the --testrunner option. This allows a test runner to define additional command line arguments. """ self.test_runner = get_command_line_option(argv, "--testrunner") super().run_from_argv(argv) [03b5c79a]
- class Command(BaseCommand): help = "Discover and run tests in the specified modules or the current directory." [f0074235]
- from django.conf import settings from django.core.management.base import BaseCommand from django.core.management.utils import get_command_line_option from django.test.runner import get_max_test_processes from django.test.utils import NullTimeKeeper, TimeKeeper, get_runner [d23f45b3]
- import sys [6b0cb2be5ea1bc3c-3]
