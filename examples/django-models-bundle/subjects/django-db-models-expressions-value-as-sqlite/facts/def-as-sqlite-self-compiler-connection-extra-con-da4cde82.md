# Fact da4cde82

Store id: d4d816fc-d567-4917-84d6-ac907e1a6c7e

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:31:55.8612480+00:00`

## Data

```json
{
  "end_line": 1203,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1193,
  "symbol": "Value.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1193,"selector":"L1193-L1203","symbol":"Value.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1203,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1193,
    "symbol": "Value.as_sqlite"
  },
  "id": "d4d816fc-d567-4917-84d6-ac907e1a6c7e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8612480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1193,
        "selector": "L1193-L1203",
        "symbol": "Value.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "00157ffe-1523-4103-a14f-73cf890a4706",
  "subject_name": "django/db/models/expressions::Value.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
