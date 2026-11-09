# Fact 0c2560ac

Store id: c2951d61-2dff-43a3-8b79-45196e8d2ac0

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.1724800+00:00`

## Data

```json
{
  "end_line": 2246,
  "entity_kind": "method",
  "parent": "BigIntegerField",
  "start_line": 2245,
  "symbol": "BigIntegerField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2245,"selector":"L2245-L2246","symbol":"BigIntegerField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigIntegerField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2246,
    "entity_kind": "method",
    "parent": "BigIntegerField",
    "start_line": 2245,
    "symbol": "BigIntegerField.get_internal_type"
  },
  "id": "c2951d61-2dff-43a3-8b79-45196e8d2ac0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1724800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2245,
        "selector": "L2245-L2246",
        "symbol": "BigIntegerField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "196254e1-a9ed-41b3-96a4-167d9b5b4ada",
  "subject_name": "django/db/models/fields/__init__::BigIntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
