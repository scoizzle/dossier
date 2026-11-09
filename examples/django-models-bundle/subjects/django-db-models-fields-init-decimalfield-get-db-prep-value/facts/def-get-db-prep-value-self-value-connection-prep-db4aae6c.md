# Fact db4aae6c

Store id: 783bf1b1-73b9-42da-8bc0-81607bfc9ac8

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
- posted_at: `2026-11-09T22:39:42.4634100+00:00`

## Data

```json
{
  "end_line": 1919,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1915,
  "symbol": "DecimalField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1915,"selector":"L1915-L1919","symbol":"DecimalField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1919,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1915,
    "symbol": "DecimalField.get_db_prep_value"
  },
  "id": "783bf1b1-73b9-42da-8bc0-81607bfc9ac8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4634100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1915,
        "selector": "L1915-L1919",
        "symbol": "DecimalField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bbf58260-e1ab-4b31-a0cc-3854c695b4c1",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
