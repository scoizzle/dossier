# Fact ab51e9fa

Store id: 92097f8e-965b-4013-94c1-687e44a88a97

## Text

```text
def _values(self, *fields, **expressions)
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
- posted_at: `2026-11-09T22:39:49.5729250+00:00`

## Data

```json
{
  "end_line": 1557,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1546,
  "symbol": "QuerySet._values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1546,"selector":"L1546-L1557","symbol":"QuerySet._values"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1557,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1546,
    "symbol": "QuerySet._values"
  },
  "id": "92097f8e-965b-4013-94c1-687e44a88a97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5729250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1546,
        "selector": "L1546-L1557",
        "symbol": "QuerySet._values"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "47de68e2-0315-409b-83c9-e98153617dac",
  "subject_name": "django/db/models/query::QuerySet._values",
  "tags": [
    "entity:method"
  ],
  "text": "def _values(self, *fields, **expressions)"
}
```
