# Fact 7a9d8003

Store id: e54a4ef7-059c-4a52-9b5e-a4c7e6c69d7d

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:50.3000280+00:00`

## Data

```json
{
  "end_line": 2833,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2830,
  "symbol": "UUIDField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2830,"selector":"L2830-L2833","symbol":"UUIDField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2833,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2830,
    "symbol": "UUIDField.deconstruct"
  },
  "id": "e54a4ef7-059c-4a52-9b5e-a4c7e6c69d7d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3000280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2830,
        "selector": "L2830-L2833",
        "symbol": "UUIDField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "301ddad3-1547-42cf-a9d4-8a6634fae580",
  "subject_name": "django/db/models/fields/__init__::UUIDField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
