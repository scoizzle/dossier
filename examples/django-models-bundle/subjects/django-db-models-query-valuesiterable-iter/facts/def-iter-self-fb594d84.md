# Fact fb594d84

Store id: a24026ae-a132-4148-8ad3-088291cddac0

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:44:55.7940900+00:00`

## Data

```json
{
  "end_line": 284,
  "entity_kind": "method",
  "parent": "ValuesIterable",
  "start_line": 266,
  "symbol": "ValuesIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":266,"selector":"L266-L284","symbol":"ValuesIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::ValuesIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 284,
    "entity_kind": "method",
    "parent": "ValuesIterable",
    "start_line": 266,
    "symbol": "ValuesIterable.__iter__"
  },
  "id": "a24026ae-a132-4148-8ad3-088291cddac0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7940900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 266,
        "selector": "L266-L284",
        "symbol": "ValuesIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "78eba1a4-9592-4896-aeac-625186d64737",
  "subject_name": "django/db/models/query::ValuesIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
