# django/contrib/auth/validators

- Subject: django/contrib/auth/validators (id `b1cbbe09-6b05-4f9a-b3c6-af8485bc45f0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 205 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- @deconstructible class ASCIIUsernameValidator(validators.RegexValidator): regex = r"^[\w.@+-]+\Z" message = _( "Enter a valid username. This value may contain only unaccented lowercase a-z " "and uppercase A-Z letters, numbers, and @/./+/-/_ characters." ) flags = re.ASCII [ecca9419]
- @deconstructible class UnicodeUsernameValidator(validators.RegexValidator): regex = r"^[\w.@+-]+\Z" message = _( "Enter a valid username. This value may contain only letters, " "numbers, and @/./+/-/_ characters." ) flags = 0 [f107e6f2]
- from django.core import validators from django.utils.deconstruct import deconstructible from django.utils.translation import gettext_lazy as _ [1c0c4a09]
- import re [dae3b101b4aa9562-2]
