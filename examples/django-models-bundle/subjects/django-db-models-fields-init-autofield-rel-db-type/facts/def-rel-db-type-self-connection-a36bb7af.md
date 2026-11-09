# Fact a36bb7af

Store id: 1b464287-4460-4af6-8270-eb0bf08e964f

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
- posted_at: `2026-11-09T23:31:56.9233740+00:00`

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
  "id": "1b464287-4460-4af6-8270-eb0bf08e964f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9233740+00:00"
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
  "subject_id": "55409afe-e30c-473d-b960-2adbbcef8d93",
  "subject_name": "django/db/models/fields/__init__::AutoField.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
