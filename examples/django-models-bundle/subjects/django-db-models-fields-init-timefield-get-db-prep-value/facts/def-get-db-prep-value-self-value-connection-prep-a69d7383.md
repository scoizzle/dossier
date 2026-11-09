# Fact a69d7383

Store id: 8fa9ff30-8969-41e3-a324-cc19550f3177

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
- posted_at: `2026-11-09T23:31:56.8263590+00:00`

## Data

```json
{
  "end_line": 2704,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2700,
  "symbol": "TimeField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2700,"selector":"L2700-L2704","symbol":"TimeField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2704,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2700,
    "symbol": "TimeField.get_db_prep_value"
  },
  "id": "8fa9ff30-8969-41e3-a324-cc19550f3177",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8263590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2700,
        "selector": "L2700-L2704",
        "symbol": "TimeField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "28d9e74e-ee3f-4ce3-9e7f-592e82f41ffb",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
