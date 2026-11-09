# django/contrib/staticfiles/management/commands/findstatic

- Subject: django/contrib/staticfiles/management/commands/findstatic (id `8e053575-9832-406a-bbf9-d621a42187b0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 347 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def add_arguments(self, parser): super().add_arguments(parser) parser.add_argument( "--first", action="store_false", dest="all", help="Only return the first match for each static file.", ) [734f662a]
- def handle_label(self, path, **options): verbosity = options["verbosity"] result = finders.find(path, find_all=options["all"]) if verbosity >= 2: searched_locations = ( "\nLooking in the following locations:\n %s" % "\n ".join([str(loc) for loc in finders.searched_locations]) ) else: searched_locations = "" if result: if not isinstance(result, (list, tuple)): result = [result] result = (os.path.realpath(path) for path in result) if verbosity >= 1: file_list = "\n ".join(result) return "Found '%s' here:\n %s%s" % ( path, file_list, searched_locations, ) else: return "\n".join(result) else: message = ["No matching file found for '%s'." % path] if verbosity >= 2: message.append(searched_locations) if verbosity >= 1: self.stderr.write("\n".join(message)) [b8ae7f9d]
- class Command(LabelCommand): help = "Finds the absolute paths for the given static file(s)." label = "staticfile" [600413e1]
- from django.contrib.staticfiles import finders from django.core.management.base import LabelCommand [81e392e0]
- import os [bbf3e0cdec1c52e4-2]
