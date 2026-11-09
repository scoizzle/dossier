# Fact 28eec870

Store id: fc2b3660-0918-484e-a80d-3e49d18206b3

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
- posted_at: `2026-11-09T23:31:56.5877920+00:00`

## Data

```json
{
  "end_line": 1584,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1580,
  "symbol": "DateField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1580,"selector":"L1580-L1584","symbol":"DateField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1584,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1580,
    "symbol": "DateField.get_db_prep_value"
  },
  "id": "fc2b3660-0918-484e-a80d-3e49d18206b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5877920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1580,
        "selector": "L1580-L1584",
        "symbol": "DateField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4ab03171-c3ce-4c26-ac0f-db81bed62885",
  "subject_name": "django/db/models/fields/__init__::DateField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
