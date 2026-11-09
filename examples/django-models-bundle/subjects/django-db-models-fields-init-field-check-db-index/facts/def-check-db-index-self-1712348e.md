# Fact 1712348e

Store id: 9e127737-f1fe-49fe-9a63-09f8814b9351

## Text

```text
def _check_db_index(self)
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
- posted_at: `2026-11-09T22:39:42.2781120+00:00`

## Data

```json
{
  "end_line": 471,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 461,
  "symbol": "Field._check_db_index"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":461,"selector":"L461-L471","symbol":"Field._check_db_index"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_db_index](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 471,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 461,
    "symbol": "Field._check_db_index"
  },
  "id": "9e127737-f1fe-49fe-9a63-09f8814b9351",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2781120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 461,
        "selector": "L461-L471",
        "symbol": "Field._check_db_index"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "158acf50-2030-42fa-ae52-61ca79145dbb",
  "subject_name": "django/db/models/fields/__init__::Field._check_db_index",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_db_index(self)"
}
```
