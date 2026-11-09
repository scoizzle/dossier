# Fact 05fc588d

Store id: af283197-94ad-4fb7-9e87-17fa2675e882

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
- posted_at: `2026-11-09T22:39:46.1068520+00:00`

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
  "id": "af283197-94ad-4fb7-9e87-17fa2675e882",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1068520+00:00"
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
  "subject_id": "549e82f4-e3c6-4eea-8603-72a38ec5e880",
  "subject_name": "django/db/models/functions/datetime::Extract.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, lookup_name=None, tzinfo=None, **extra)"
}
```
