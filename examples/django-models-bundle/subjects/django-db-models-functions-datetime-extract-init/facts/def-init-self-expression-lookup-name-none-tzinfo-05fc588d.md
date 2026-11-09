# Fact 05fc588d

Store id: 20f6897b-3b7e-4719-a518-1231239af7cd

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
- posted_at: `2026-11-09T23:32:01.1730140+00:00`

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
  "id": "20f6897b-3b7e-4719-a518-1231239af7cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.1730140+00:00"
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
  "subject_id": "a444dbcd-a4f1-4cdc-ab03-7de3d0e20d37",
  "subject_name": "django/db/models/functions/datetime::Extract.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, lookup_name=None, tzinfo=None, **extra)"
}
```
