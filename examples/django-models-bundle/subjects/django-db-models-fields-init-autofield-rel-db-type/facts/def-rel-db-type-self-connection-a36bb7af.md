# Fact a36bb7af

Store id: e7dd2110-f3be-4395-bf44-ad5d693b8e73

## Text

```text
def rel_db_type(self, connection)
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
- posted_at: `2026-11-09T23:44:50.3376940+00:00`

## Data

```json
{
  "end_line": 2968,
  "entity_kind": "method",
  "parent": "AutoField",
  "start_line": 2967,
  "symbol": "AutoField.rel_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2967,"selector":"L2967-L2968","symbol":"AutoField.rel_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoField.rel_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2968,
    "entity_kind": "method",
    "parent": "AutoField",
    "start_line": 2967,
    "symbol": "AutoField.rel_db_type"
  },
  "id": "e7dd2110-f3be-4395-bf44-ad5d693b8e73",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3376940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2967,
        "selector": "L2967-L2968",
        "symbol": "AutoField.rel_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "69a1a46b-a44f-47e5-b84d-b9f14575101f",
  "subject_name": "django/db/models/fields/__init__::AutoField.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
