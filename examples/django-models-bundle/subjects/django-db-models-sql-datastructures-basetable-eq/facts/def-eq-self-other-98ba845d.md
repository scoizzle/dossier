# Fact 98ba845d

Store id: a7a79134-5a7b-4e06-84df-fee73f72f35b

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:58.2835370+00:00`

## Data

```json
{
  "end_line": 219,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 216,
  "symbol": "BaseTable.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":216,"selector":"L216-L219","symbol":"BaseTable.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 219,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 216,
    "symbol": "BaseTable.__eq__"
  },
  "id": "a7a79134-5a7b-4e06-84df-fee73f72f35b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.2835370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 216,
        "selector": "L216-L219",
        "symbol": "BaseTable.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "9a82a186-bf7d-4e28-80d0-b7721a624e23",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
