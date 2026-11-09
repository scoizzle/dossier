# django/contrib/auth/validators

- Subject: django/contrib/auth/validators (id `070d3d52-6e39-4f61-a186-6ddf3b58afa8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 205 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @deconstructible class ASCIIUsernameValidator(validators.RegexValidator): regex = r"^[\w.@+-]+\Z" message = _( "Enter a valid username. This value may contain only unaccented lowercase a-z " "and uppercase A-Z letters, numbers, and @/./+/-/_ characters." ) flags = re.ASCII [ecca9419]
- @deconstructible class UnicodeUsernameValidator(validators.RegexValidator): regex = r"^[\w.@+-]+\Z" message = _( "Enter a valid username. This value may contain only letters, " "numbers, and @/./+/-/_ characters." ) flags = 0 [f107e6f2]
- from django.core import validators from django.utils.deconstruct import deconstructible from django.utils.translation import gettext_lazy as _ [1c0c4a09]
- import re [dae3b101b4aa9562-2]
