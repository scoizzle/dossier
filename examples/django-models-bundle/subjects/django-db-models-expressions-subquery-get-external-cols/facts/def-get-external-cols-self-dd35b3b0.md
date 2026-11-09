# Fact dd35b3b0

Store id: a8a39c19-2731-4d96-aa59-d9d02d469ef4

## Text

```text
def get_external_cols(self)
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
- posted_at: `2026-11-09T23:44:49.6431260+00:00`

## Data

```json
{
  "end_line": 1871,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1870,
  "symbol": "Subquery.get_external_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1870,"selector":"L1870-L1871","symbol":"Subquery.get_external_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.get_external_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1871,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1870,
    "symbol": "Subquery.get_external_cols"
  },
  "id": "a8a39c19-2731-4d96-aa59-d9d02d469ef4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6431260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1870,
        "selector": "L1870-L1871",
        "symbol": "Subquery.get_external_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8aeb5255-c0ef-44c9-a578-92da49111c23",
  "subject_name": "django/db/models/expressions::Subquery.get_external_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_external_cols(self)"
}
```
