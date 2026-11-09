# Fact 554f0c59

Store id: 7dd20230-185c-4a16-b383-465ede516a5d

## Text

```text
def __init__( self, expression, output_field=None, tzinfo=None, **extra, )
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:01.2543980+00:00`

## Data

```json
{
  "end_line": 256,
  "entity_kind": "method",
  "parent": "TruncBase",
  "start_line": 248,
  "symbol": "TruncBase.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":248,"selector":"L248-L256","symbol":"TruncBase.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 256,
    "entity_kind": "method",
    "parent": "TruncBase",
    "start_line": 248,
    "symbol": "TruncBase.__init__"
  },
  "id": "7dd20230-185c-4a16-b383-465ede516a5d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2543980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 248,
        "selector": "L248-L256",
        "symbol": "TruncBase.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "3c280058-6a7e-43ca-8a3f-658498060039",
  "subject_name": "django/db/models/functions/datetime::TruncBase.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, expression, output_field=None, tzinfo=None, **extra, )"
}
```
