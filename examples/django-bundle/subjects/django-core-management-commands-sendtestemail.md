# django/core/management/commands/sendtestemail

- Subject: django/core/management/commands/sendtestemail (id `f345cf82-d129-4ae3-a1bd-c4c22c6845cb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 399 tokens
- Facts shown: 7 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- if kwargs["admins"]: mail_admins(subject, "This email was sent to the site admins.", using=using) [ebb03c55]
- send_mail( subject=subject, message="If you're reading this, it was successful.", from_email=None, recipient_list=kwargs["email"], using=using, ) [87e0a86c]
- def add_arguments(self, parser): parser.add_argument( "email", nargs="*", help="One or more email addresses to send a test email to.", ) parser.add_argument( "--managers", action="store_true", help="Send a test email to the addresses specified in settings.MANAGERS.", ) parser.add_argument( "--admins", action="store_true", help="Send a test email to the addresses specified in settings.ADMINS.", ) parser.add_argument( "--using", default=None, help=( "Specify the MAILERS alias to use for sending the test email. " "Defaults to 'default'." ), ) [520ed5cb]
- def handle(self, *args, using=None, **kwargs): subject = "Test email from %s on %s" % (socket.gethostname(), timezone.now()) [9c06e94b]
- class Command(BaseCommand): help = "Sends a test email to the email addresses specified as arguments." missing_args_message = ( "You must specify some email recipients, or pass the --managers or --admin " "options." ) [925977da]
- from django.core.mail import mail_admins, mail_managers, send_mail from django.core.management.base import BaseCommand from django.utils import timezone [c1ea4748]
- import socket [63a09fd79c1eb796-2]
