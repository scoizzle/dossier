# Fact 4f50794a

Store id: e89b53db-1771-476c-a725-c0ed1f96c31d

## Text

```text
def __instancecheck__(self, instance)
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
- posted_at: `2026-11-09T23:32:04.6940730+00:00`

## Data

```json
{
  "end_line": 2397,
  "entity_kind": "method",
  "parent": "InstanceCheckMeta",
  "start_line": 2396,
  "symbol": "InstanceCheckMeta.__instancecheck__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2396,"selector":"L2396-L2397","symbol":"InstanceCheckMeta.__instancecheck__"}`

## Referenced by

None.

## Subject

[django/db/models/query::InstanceCheckMeta.__instancecheck__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2397,
    "entity_kind": "method",
    "parent": "InstanceCheckMeta",
    "start_line": 2396,
    "symbol": "InstanceCheckMeta.__instancecheck__"
  },
  "id": "e89b53db-1771-476c-a725-c0ed1f96c31d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6940730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2396,
        "selector": "L2396-L2397",
        "symbol": "InstanceCheckMeta.__instancecheck__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6418de74-1b12-407a-8a3a-9491a1a997f7",
  "subject_name": "django/db/models/query::InstanceCheckMeta.__instancecheck__",
  "tags": [
    "entity:method"
  ],
  "text": "def __instancecheck__(self, instance)"
}
```
