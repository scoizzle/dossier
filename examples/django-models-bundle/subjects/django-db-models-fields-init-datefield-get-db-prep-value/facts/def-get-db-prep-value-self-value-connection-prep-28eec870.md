# Fact 28eec870

Store id: bb49657d-0927-4d56-bed9-6169cf6c5107

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
- posted_at: `2026-11-09T22:39:42.4237670+00:00`

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
  "id": "bb49657d-0927-4d56-bed9-6169cf6c5107",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4237670+00:00"
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
  "subject_id": "22466510-369c-4b9a-82a8-6b29f8b92251",
  "subject_name": "django/db/models/fields/__init__::DateField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
