# Fact ba8df1b7

Store id: 8eacc2f4-fea9-4bad-889e-63e9fc4b6796

## Text

```text
class DataContains(FieldGetDbPrepValueMixin, PostgresOperatorLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.8655340+00:00`

## Data

```json
{
  "end_line": 165,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 153,
  "symbol": "DataContains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":153,"selector":"L153-L165","symbol":"DataContains"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::DataContains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 165,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 153,
    "symbol": "DataContains"
  },
  "id": "8eacc2f4-fea9-4bad-889e-63e9fc4b6796",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8655340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 153,
        "selector": "L153-L165",
        "symbol": "DataContains"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7b0bc489-c840-45fa-8cb0-3cac4764a7b7",
  "subject_name": "django/db/models/fields/json::DataContains",
  "tags": [
    "entity:class"
  ],
  "text": "class DataContains(FieldGetDbPrepValueMixin, PostgresOperatorLookup)"
}
```
