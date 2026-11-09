# Fact 6f9a8ed7

Store id: f567e41d-7ce0-47c1-9212-e4b6a38f4a4c

## Text

```text
def get_db_prep_value(self, value, connection, prepared=False)
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
- posted_at: `2026-11-09T23:44:50.1647150+00:00`

## Data

```json
{
  "end_line": 2215,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2213,
  "symbol": "IntegerField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2213,"selector":"L2213-L2215","symbol":"IntegerField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2215,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2213,
    "symbol": "IntegerField.get_db_prep_value"
  },
  "id": "f567e41d-7ce0-47c1-9212-e4b6a38f4a4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1647150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2213,
        "selector": "L2213-L2215",
        "symbol": "IntegerField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "947d6060-ba9f-4d9a-a0db-c5c60bff4287",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
