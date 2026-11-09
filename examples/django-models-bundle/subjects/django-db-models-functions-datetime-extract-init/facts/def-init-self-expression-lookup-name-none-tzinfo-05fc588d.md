# Fact 05fc588d

Store id: 7bb428ab-59c5-410f-8722-c5c641ad13b0

## Text

```text
def __init__(self, expression, lookup_name=None, tzinfo=None, **extra)
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
- posted_at: `2026-11-09T23:44:53.3208540+00:00`

## Data

```json
{
  "end_line": 49,
  "entity_kind": "method",
  "parent": "Extract",
  "start_line": 43,
  "symbol": "Extract.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":43,"selector":"L43-L49","symbol":"Extract.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Extract.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 49,
    "entity_kind": "method",
    "parent": "Extract",
    "start_line": 43,
    "symbol": "Extract.__init__"
  },
  "id": "7bb428ab-59c5-410f-8722-c5c641ad13b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3208540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 43,
        "selector": "L43-L49",
        "symbol": "Extract.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "faf34f5a-295d-4d4b-9ad6-15795732fa1b",
  "subject_name": "django/db/models/functions/datetime::Extract.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, lookup_name=None, tzinfo=None, **extra)"
}
```
